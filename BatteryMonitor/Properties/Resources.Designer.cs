﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatteryMonitor.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BatteryMonitor.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Экономия энергии отключена.
        /// </summary>
        internal static string Form1_OnPowerModeChanged_Power_saving_is_disabled {
            get {
                return ResourceManager.GetString("Form1_OnPowerModeChanged_Power_saving_is_disabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Экономия энергии включена.
        /// </summary>
        internal static string Form1_OnPowerModeChanged_Power_saving_is_enabled {
            get {
                return ResourceManager.GetString("Form1_OnPowerModeChanged_Power_saving_is_enabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Режим питания был изменён.
        /// </summary>
        internal static string Form1_OnPowerModeChanged_Power_status_has_changed {
            get {
                return ResourceManager.GetString("Form1_OnPowerModeChanged_Power_status_has_changed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Возникла проблема при определении режима питания.
        /// </summary>
        internal static string Form1_OnPowerModeChanged_Problem_occured_determining_power_mode {
            get {
                return ResourceManager.GetString("Form1_OnPowerModeChanged_Problem_occured_determining_power_mode", resourceCulture);
            }
        }
    }
}