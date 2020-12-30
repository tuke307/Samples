using Foundation;
using MvvmCross;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.MvvmCross.Theme.Services;
using Xamarin.MvvmCross.Theme.Themes;

namespace Xamarin.MvvmCross.Theme.iOS
{
    public class ThemeService : ThemeServiceBase
    {
        public override void UpdateTheme(ThemeMode themeMode)
        {
            base.UpdateTheme(themeMode);

            bool changed = false;

            switch (ColorSettings.Theme)
            {
                case (int)ThemeMode.Inherit:
                    // do something ios specific
                    changed = true;
                    break;

                case (int)ThemeMode.Dark:
                    // do something ios specific
                    changed = true;
                    break;

                case (int)ThemeMode.Light:
                    // do something ios specific
                    changed = true;
                    break;

                default:
                    break;
            }

            //restart appliation maybe
        }
    }
}