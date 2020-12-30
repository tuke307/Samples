using MvvmCross;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;
using UIKit;
using Xamarin.MvvmCross.Theme.Services;

namespace Xamarin.MvvmCross.Theme.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.RegisterType<IThemeService, ThemeService>();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

            //var registry = Mvx.IoCProvider.Resolve<IMvxTargetBindingFactoryRegistry>();
            //registry.RegisterFactory(new MvxCustomBindingFactory<UIViewController>("NetworkIndicator", (viewController) => new NetworkIndicatorTargetBinding(viewController)));
        }

        protected override IMvxIocOptions CreateIocOptions()
        {
            return new MvxIocOptions
            {
                PropertyInjectorOptions = MvxPropertyInjectorOptions.MvxInject
            };
        }
    }
}