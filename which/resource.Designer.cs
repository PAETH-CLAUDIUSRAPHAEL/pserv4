﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace which {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("which.resource", typeof(resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to add directory &lt;name&gt;, can be a ; separated list.
        /// </summary>
        internal static string IDS_CMD_dir_doc {
            get {
                return ResourceManager.GetString("IDS_CMD_dir_doc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to environment variable, defaults to PATH.
        /// </summary>
        internal static string IDS_CMD_env_doc {
            get {
                return ResourceManager.GetString("IDS_CMD_env_doc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to search for extension &lt;name&gt;, can be a ; separated list.
        /// </summary>
        internal static string IDS_CMD_extension_doc {
            get {
                return ResourceManager.GetString("IDS_CMD_extension_doc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to one or more files to find.
        /// </summary>
        internal static string IDS_CMD_file_doc {
            get {
                return ResourceManager.GetString("IDS_CMD_file_doc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to search directories recursively.
        /// </summary>
        internal static string IDS_CMD_recursive_doc {
            get {
                return ResourceManager.GetString("IDS_CMD_recursive_doc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to stop after the first find result.
        /// </summary>
        internal static string IDS_CMD_single_doc {
            get {
                return ResourceManager.GetString("IDS_CMD_single_doc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Freeware written by Gerson Kurz (http://p-nand-q.com).
        /// </summary>
        internal static string IDS_COPYRIGHT {
            get {
                return ResourceManager.GetString("IDS_COPYRIGHT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to =&gt; Directory &apos;{0}&apos; does not exist.
        /// </summary>
        internal static string IDS_ERR_dir_does_not_exist {
            get {
                return ResourceManager.GetString("IDS_ERR_dir_does_not_exist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR, &apos;{0}&apos; is not a valid environment variable.
        /// </summary>
        internal static string IDS_ERR_invalid_env_var {
            get {
                return ResourceManager.GetString("IDS_ERR_invalid_env_var", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to looking for &apos;{0}&apos;.
        /// </summary>
        internal static string IDS_ERR_looking_for {
            get {
                return ResourceManager.GetString("IDS_ERR_looking_for", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, &apos;{0}&apos; not found.
        /// </summary>
        internal static string IDS_ERR_not_found {
            get {
                return ResourceManager.GetString("IDS_ERR_not_found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to while parsing &apos;{0}&apos;.
        /// </summary>
        internal static string IDS_ERR_while_parsing {
            get {
                return ResourceManager.GetString("IDS_ERR_while_parsing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} [{1}, {2} bytes].
        /// </summary>
        internal static string IDS_RESULT_PATTERN {
            get {
                return ResourceManager.GetString("IDS_RESULT_PATTERN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version {0}.
        /// </summary>
        internal static string IDS_TITLE {
            get {
                return ResourceManager.GetString("IDS_TITLE", resourceCulture);
            }
        }
    }
}