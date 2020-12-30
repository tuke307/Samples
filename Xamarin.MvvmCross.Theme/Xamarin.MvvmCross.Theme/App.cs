using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.MvvmCross.Theme
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            // register the appstart object
            RegisterCustomAppStart<AppStart>();
        }
    }
}