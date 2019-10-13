﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mpvnet.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("mpvnet.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to 
        /// # This file defines the key and mouse bindings and the context menu
        /// # of mpv.net. A input and config editor can be found in mpv.net&apos;s
        /// # context menu under &apos;Settings&apos;. The defaults of this file can be found at:
        ///
        /// # https://github.com/stax76/mpv.net/blob/master/mpv.net/Resources/inputConf.txt
        ///
        /// # The defaults of mpv can be found at:
        ///
        /// # https://github.com/mpv-player/mpv/blob/master/etc/input.conf
        ///
        /// # mpv.net&apos;s defaults of mpv.conf contain: &apos;input-default-bindings = no&apos;
        /// # which disables mpv&apos;s  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string inputConf {
            get {
                return ResourceManager.GetString("inputConf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to input-default-bindings = no
        ///input-ar-delay = 500
        ///input-ar-rate = 20
        ///keep-open = yes
        ///keep-open-pause = no
        ///osd-playing-msg = &apos;${filename}&apos;
        ///script-opts=osc-scalewindowed=1.5
        ///screenshot-directory = &apos;~~desktop/&apos;
        ///cscale = spline36
        ///dscale = spline36
        ///scale = spline36
        ///hwdec = yes
        ///
        ///[protocol.https]
        ///osd-playing-msg = &apos;${media-title}&apos;.
        /// </summary>
        internal static string mpvConf {
            get {
                return ResourceManager.GetString("mpvConf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [[settings]]
        ///name = &quot;hwdec&quot;
        ///default = &quot;no&quot;
        ///filter = &quot;Video&quot;
        ///url = &quot;https://mpv.io/manual/master/#options-hwdec&quot;
        ///help = &quot;Specify the hardware video decoding API that should be used if possible. Whether hardware decoding is actually done depends on the video codec. If hardware decoding is not possible, mpv will fall back on software decoding.\n\nFor more information visit:&quot;
        ///options = [{ name = &quot;no&quot;,           help = &quot;always use software decoding&quot; },
        ///           { name = &quot;auto&quot;,         help = &quot;enable be [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string mpvConfToml {
            get {
                return ResourceManager.GetString("mpvConfToml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap mpvnet {
            get {
                object obj = ResourceManager.GetObject("mpvnet", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dark-color = &apos;#1E90FF&apos;
        ///light-color = &apos;#28394F&apos;.
        /// </summary>
        internal static string mpvNetConf {
            get {
                return ResourceManager.GetString("mpvNetConf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [[settings]]
        ///name = &quot;process-instance&quot;
        ///default = &quot;single&quot;
        ///filter = &quot;General&quot;
        ///help = &quot;Defines if more then one mpv.net process is allowed. (mpv.net specific setting)\n\nTip: Whenever the control key is pressed when files or URLs are opened, the playlist is not cleared but the files or URLs are appended to the playlist. This not only works on process startup but in all mpv.net features that open files and URLs.&quot;
        ///options = [{ name = &quot;multi&quot;,  help = &quot;Create a new process everytime the shell starts mpv.net [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string mpvNetConfToml {
            get {
                return ResourceManager.GetString("mpvNetConfToml", resourceCulture);
            }
        }
    }
}
