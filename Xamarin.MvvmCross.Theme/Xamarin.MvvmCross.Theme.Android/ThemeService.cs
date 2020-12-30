namespace Xamarin.MvvmCross.Theme.Droid
{
    using Android.App;
    using AndroidX.AppCompat.App;
    using global::MvvmCross;
    using global::MvvmCross.Platforms.Android;
    using Xamarin.MvvmCross.Theme.Services;
    using Xamarin.MvvmCross.Theme.Themes;

    public class ThemeService : ThemeServiceBase
    {
        Activity Activity => Mvx.IoCProvider.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

        public override void UpdateTheme(ThemeMode themeMode)
        {
            base.UpdateTheme(themeMode);

            bool changed = false;

            switch (ColorSettings.Theme)
            {
                case (int)ThemeMode.Inherit:
                    if (AppCompatDelegate.DefaultNightMode != AppCompatDelegate.ModeNightFollowSystem)
                    {
                        AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightFollowSystem;
                        changed = true;
                    }
                    break;

                case (int)ThemeMode.Dark:
                    if (AppCompatDelegate.DefaultNightMode != AppCompatDelegate.ModeNightYes)
                    {
                        AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightYes;
                        changed = true;
                    }
                    break;

                case (int)ThemeMode.Light:
                    if (AppCompatDelegate.DefaultNightMode != AppCompatDelegate.ModeNightNo)
                    {
                        AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightNo;
                        changed = true;
                    }
                    break;

                default:
                    break;
            }

            if (this.Activity?.Theme != null && changed)
            {
                (this.Activity as MainActivity)?.Delegate.ApplyDayNight();
                this.Activity.Recreate();
            }
        }
    }
}