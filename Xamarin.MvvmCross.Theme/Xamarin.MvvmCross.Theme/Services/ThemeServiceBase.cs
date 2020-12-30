using Xamarin.MvvmCross.Theme.Themes;

namespace Xamarin.MvvmCross.Theme.Services
{
    /// <summary>
    /// ThemeServiceBase.
    /// </summary>
    /// <seealso cref="LapTimer.Forms.UI.Services.IThemeService" />
    public class ThemeServiceBase : IThemeService
    {
        /// <summary>
        /// Gets the current runtime theme.
        /// </summary>
        /// <value>The current runtime theme.</value>
        public ThemeMode CurrentRuntimeTheme { get; private set; }

        /// <summary>
        /// Updates the theme.
        /// </summary>
        /// <param name="themeMode">The theme mode.</param>
        public virtual void UpdateTheme(ThemeMode themeMode)
        {
            switch (ColorSettings.Theme)
            {
                case (int)ThemeMode.Inherit:
                    if (themeMode == ThemeMode.Dark)
                        goto case (int)ThemeMode.Dark;
                    else
                        goto case (int)ThemeMode.Light;
                case (int)ThemeMode.Dark:
                    SetTheme(ThemeMode.Dark);
                    break;

                case (int)ThemeMode.Light:
                    SetTheme(ThemeMode.Light);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Sets the colors.
        /// </summary>
        /// <param name="themeMode">The theme mode.</param>
        private void SetColors(ThemeMode themeMode)
        {
            // do something
        }

        /// <summary>
        /// Sets the theme.
        /// </summary>
        /// <param name="themeMode">The theme mode.</param>
        private void SetTheme(ThemeMode themeMode)
        {
            if (CurrentRuntimeTheme == themeMode)
            {
                return;
            }

            this.SetColors(themeMode);

            CurrentRuntimeTheme = themeMode;
        }
    }
}