using Xamarin.MvvmCross.Theme.Themes;

namespace Xamarin.MvvmCross.Theme.Services
{
    public interface IThemeService
    {
        void UpdateTheme(ThemeMode themeMode = ThemeMode.Inherit);
    }
}