using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace MvvmCross.WPF.View2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            base.RegisterSetup();
            this.RegisterSetupType<MvxWpfSetup<MvxApp>>();
        }
    }
}