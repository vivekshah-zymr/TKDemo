using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using TK.CustomMap.iOSUnified;
using Foundation;
using UIKit;

namespace TKDemo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Forms.Init();
            FormsMaps.Init();
            Xamarin.FormsMaps.Init();
            TKCustomMapRenderer.InitMapRenderer();
            NativePlacesApi.Init();
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
}
