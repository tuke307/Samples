using MvvmCross;
using MvvmCross.Platforms.Android.Core;
using Xamarin.MvvmCross.Theme.Services;

namespace Xamarin.MvvmCross.Theme.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.RegisterType<IThemeService, ThemeService>();
        }
    }
}