﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GladLive.ProxyLoadBalancer.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class InboundConnectionSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static InboundConnectionSettings defaultInstance = ((InboundConnectionSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new InboundConnectionSettings())));
        
        public static InboundConnectionSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5056")]
        public int AuthServiceSessionPort {
            get {
                return ((int)(this["AuthServiceSessionPort"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5055")]
        public int ClientSessionPort {
            get {
                return ((int)(this["ClientSessionPort"]));
            }
        }
    }
}