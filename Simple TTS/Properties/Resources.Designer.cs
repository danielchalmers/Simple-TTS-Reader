﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simple_TTS.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Simple_TTS.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} ({1})
        ///
        ///{2}
        ///Icons are made by Google from Flaticon and are licensed under CC BY 3.0
        ///
        ///{3}.
        /// </summary>
        public static string About {
            get {
                return ResourceManager.GetString("About", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simple TTS.
        /// </summary>
        public static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SimpleTTS.
        /// </summary>
        public static string AppPathName {
            get {
                return ResourceManager.GetString("AppPathName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/danielchalmers/Simple-TTS/issues.
        /// </summary>
        public static string GitHubIssues {
            get {
                return ResourceManager.GetString("GitHubIssues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap pause {
            get {
                object obj = ResourceManager.GetObject("pause", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap play {
            get {
                object obj = ResourceManager.GetObject("play", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap stop {
            get {
                object obj = ResourceManager.GetObject("stop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/danielchalmers/Simple-TTS.
        /// </summary>
        public static string Website {
            get {
                return ResourceManager.GetString("Website", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hello {0}.
        ///Welcome to Simple Text to Speech Reader version {1}.
        ///
        ///To start, stop, or pause voice playback, use the buttons above.
        ///You can find settings, help, etc in the toolbar menu at the top of the window.
        ///
        ///If you have any issues or requests, you can report them at {2}..
        /// </summary>
        public static string WelcomeMessage {
            get {
                return ResourceManager.GetString("WelcomeMessage", resourceCulture);
            }
        }
    }
}