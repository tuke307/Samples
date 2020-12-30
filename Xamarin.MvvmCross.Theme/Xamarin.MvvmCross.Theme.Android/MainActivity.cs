using System;
using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using MvvmCross;
using MvvmCross.Platforms.Android.Views;
using Xamarin.MvvmCross.Theme;
using Xamarin.MvvmCross.Theme.Droid;
using Xamarin.MvvmCross.Theme.Services;
using Xamarin.MvvmCross.Theme.Themes;

namespace LapTimer.Forms.UI.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication()
        {
        }

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            this.UpdateTheme(newConfig);
        }

        private void UpdateTheme(Configuration newConfig)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Froyo)
            {
                var uiModeFlags = newConfig.UiMode & UiMode.NightMask;
                switch (uiModeFlags)
                {
                    case UiMode.NightYes:
                        Mvx.IoCProvider.Resolve<IThemeService>().UpdateTheme(ThemeMode.Dark);
                        break;

                    case UiMode.NightNo:
                        Mvx.IoCProvider.Resolve<IThemeService>().UpdateTheme(ThemeMode.Light);
                        break;

                    default:
                        throw new NotSupportedException($"UiMode {uiModeFlags} not supported");
                }
            }
        }
    }
}