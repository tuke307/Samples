using MvvmCross;
using System;
using UIKit;
using Xamarin.MvvmCross.Theme.Services;
using Xamarin.MvvmCross.Theme.Themes;

namespace Xamarin.MvvmCross.Theme.iOS
{
    public class MyViewController : UIViewController
    {
        public override void TraitCollectionDidChange(UITraitCollection previousTraitCollection)
        {
            base.TraitCollectionDidChange(previousTraitCollection);

            if (TraitCollection.UserInterfaceStyle != previousTraitCollection.UserInterfaceStyle)
            {
                UpdateTheme(TraitCollection.UserInterfaceStyle);
            }
        }

        private void UpdateTheme(UIUserInterfaceStyle newConfig)
        {
            switch (newConfig)
            {
                case UIUserInterfaceStyle.Dark:
                    Mvx.IoCProvider.Resolve<IThemeService>().UpdateTheme(ThemeMode.Dark);
                    break;

                case UIUserInterfaceStyle.Light:
                    Mvx.IoCProvider.Resolve<IThemeService>().UpdateTheme(ThemeMode.Light);
                    break;

                default:
                    throw new NotSupportedException($"UiMode {newConfig} not supported");
            }
        }
    }
}