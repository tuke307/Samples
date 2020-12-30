using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Xamarin.MvvmCross.Theme
{
    public static class ColorSettings
    {
        private const string userFile = "color";

        /// <summary>
        /// Gets or sets the MaterialDesignThemes.Wpf.BaseTheme.
        /// </summary>
        /// <value>The theme.</value>
        public static int Theme
        {
            get
            {
                return AppSettings.GetValueOrDefault(nameof(Theme), (int)Themes.ThemeMode.Inherit, userFile);
            }

            set
            {
                AppSettings.AddOrUpdateValue(nameof(Theme), value, userFile);
            }
        }

        private static ISettings AppSettings => CrossSettings.Current;
    }
}