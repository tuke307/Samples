using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace MvvmCross.WPF.View2.ViewModels
{
    public class Tab2ViewModel : MvxNavigationViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public Tab2ViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService)
              : base(logProvider, navigationService)
        {
            this._navigationService = navigationService;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns>Initilisierung.</returns>
        public override Task Initialize()
        {
            return base.Initialize();
        }

        /// <summary>
        /// Prepares this instance. called after construction.
        /// </summary>
        public override void Prepare()
        {
            base.Prepare();
        }
    }
}