﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hipparcos_DB.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://cdsarc.u-strasbg.fr/ftp/I/239/")]
        public string DefaultHostName {
            get {
                return ((string)(this["DefaultHostName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://cdsarc.u-strasbg.fr/ftp/I/239/")]
        public string UserHostName {
            get {
                return ((string)(this["UserHostName"]));
            }
            set {
                this["UserHostName"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("catalog/i239/")]
        public string DefaultHipparcosCatalogDirectory {
            get {
                return ((string)(this["DefaultHipparcosCatalogDirectory"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("catalog/i239/")]
        public string UserHipparcosCatalogDirectory {
            get {
                return ((string)(this["UserHipparcosCatalogDirectory"]));
            }
            set {
                this["UserHipparcosCatalogDirectory"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("catalog/i239/")]
        public string DefaultTychoCatalogDirectory {
            get {
                return ((string)(this["DefaultTychoCatalogDirectory"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("catalog/i239/")]
        public string UserTychoCatalogDirectory {
            get {
                return ((string)(this["UserTychoCatalogDirectory"]));
            }
            set {
                this["UserTychoCatalogDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UserEnableHoverEffect {
            get {
                return ((bool)(this["UserEnableHoverEffect"]));
            }
            set {
                this["UserEnableHoverEffect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UserEnableCopyMethod {
            get {
                return ((bool)(this["UserEnableCopyMethod"]));
            }
            set {
                this["UserEnableCopyMethod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte UserDataTableStyle {
            get {
                return ((byte)(this["UserDataTableStyle"]));
            }
            set {
                this["UserDataTableStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UserEnableQuickDownload {
            get {
                return ((bool)(this["UserEnableQuickDownload"]));
            }
            set {
                this["UserEnableQuickDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte UserStartPosition {
            get {
                return ((byte)(this["UserStartPosition"]));
            }
            set {
                this["UserStartPosition"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte DefaultStartPosition {
            get {
                return ((byte)(this["DefaultStartPosition"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DefaultEnableQuickDownload {
            get {
                return ((bool)(this["DefaultEnableQuickDownload"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DefaultEnableHoverEffect {
            get {
                return ((bool)(this["DefaultEnableHoverEffect"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte DefaultDataTableStyle {
            get {
                return ((byte)(this["DefaultDataTableStyle"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DefaultEnableCopyMethod {
            get {
                return ((bool)(this["DefaultEnableCopyMethod"]));
            }
        }
    }
}
