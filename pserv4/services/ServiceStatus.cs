﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using log4net;
using System.Reflection;

namespace pserv4.services
{
    public class ServiceStatus : IDisposable
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly NativeService Service;
        public SERVICE_STATUS_PROCESS Status = new SERVICE_STATUS_PROCESS();
        private IntPtr Memory;

        public ServiceStatus(NativeService service)
        {
            Service = service;
            Memory = Marshal.AllocHGlobal(Marshal.SizeOf(Status));
        }

        public bool Start()
        {
            if( !Service.IsValid )
            {
                Log.WarnFormat("Warning, don't attempt to call StartService on {0}", Service);
                return false;
            }
            Log.InfoFormat("StartService({0})", Service);
            if (NativeServiceFunctions.StartService(Service.Handle, 0, Memory))
                return true;

            return NativeHelpers.ReportFailure("StartService({0})", Service);
        }

        public bool Control(SC_CONTROL_CODE code)
        {
            if (!Service.IsValid)
            {
                Log.WarnFormat("Warning, don't attempt to call Control({1}) on {0}", Service, code);
                return false;
            }
            Log.InfoFormat("ControlService({0}, {1})", Service, code);
            if (NativeServiceFunctions.ControlService(Service.Handle, code, Memory))
            {
                Status = (SERVICE_STATUS_PROCESS)Marshal.PtrToStructure(
                    Memory,
                    typeof(SERVICE_STATUS_PROCESS));
                Log.InfoFormat("Currentstatus = {0}", Status.CurrentState);
                return true;
            }
            return NativeHelpers.ReportFailure("ControlService({0}, {1})", Service, code);
        }

        public bool Refresh()
        {
            if (!Service.IsValid)
            {
                Log.WarnFormat("Warning, don't attempt to call QueryServiceStatusEx() on {0}", Service);
                return false;
            }
            int bytesNeeded;

            if (NativeServiceFunctions.QueryServiceStatusEx(
                Service.Handle,
                SC_STATUS_TYPE.SC_STATUS_PROCESS_INFO,
                Memory,
                Marshal.SizeOf(Status),
                out bytesNeeded))
            {
                Status = (SERVICE_STATUS_PROCESS)Marshal.PtrToStructure(
                    Memory,
                    typeof(SERVICE_STATUS_PROCESS));
                Log.InfoFormat("CurrentStatus as returned by QSSE = {0}", Status.CurrentState);
                return true;
            }
            return NativeHelpers.ReportFailure("QueryServiceStatusEx({0})", Service);
        }

        #region IDisposable Members

        public void Dispose()
        {
            Marshal.FreeHGlobal(Memory);
        }

        #endregion
    }
}
