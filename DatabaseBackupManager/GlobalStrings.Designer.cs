﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseBackupManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class GlobalStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GlobalStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DatabaseBackupManager.GlobalStrings", typeof(GlobalStrings).Assembly);
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
        ///   Looks up a localized string similar to Back Up Database.
        /// </summary>
        internal static string BackUpDatabaseCaption {
            get {
                return ResourceManager.GetString("BackUpDatabaseCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The backup of database &apos;.
        /// </summary>
        internal static string BackUpDatabaseHeadText {
            get {
                return ResourceManager.GetString("BackUpDatabaseHeadText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos; completed successfully..
        /// </summary>
        internal static string BackUpDatabaseTailText {
            get {
                return ResourceManager.GetString("BackUpDatabaseTailText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect To Server.
        /// </summary>
        internal static string ConnectToServerCaption {
            get {
                return ResourceManager.GetString("ConnectToServerCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete Backup Device.
        /// </summary>
        internal static string DeleteBackupDeviceCaption {
            get {
                return ResourceManager.GetString("DeleteBackupDeviceCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All backups and backup history related to this backup device will be permanently deleted. You can’t undo this action.
        ///Are you sure you want to delete this backup device?.
        /// </summary>
        internal static string DeleteBackupDeviceWarningText {
            get {
                return ResourceManager.GetString("DeleteBackupDeviceWarningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore Database.
        /// </summary>
        internal static string RestoreDatabaseCaption {
            get {
                return ResourceManager.GetString("RestoreDatabaseCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database &apos;.
        /// </summary>
        internal static string RestoreDatabaseHeadText {
            get {
                return ResourceManager.GetString("RestoreDatabaseHeadText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos; restored successfully..
        /// </summary>
        internal static string RestoreDatabaseTailText {
            get {
                return ResourceManager.GetString("RestoreDatabaseTailText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring: .
        /// </summary>
        internal static string RestoringText {
            get {
                return ResourceManager.GetString("RestoringText", resourceCulture);
            }
        }
    }
}