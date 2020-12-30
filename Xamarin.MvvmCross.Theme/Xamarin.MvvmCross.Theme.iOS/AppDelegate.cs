namespace SimTuning.Forms.iOS
{
    using Foundation;
    using UIKit;
    using MvvmCross.Platforms.Ios.Core;
    using Xamarin.MvvmCross.Theme.iOS;
    using Xamarin.MvvmCross.Theme;

    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            return base.FinishedLaunching(application, launchOptions);
        }
    }
}