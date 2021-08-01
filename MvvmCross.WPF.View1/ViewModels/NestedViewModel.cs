using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.IoC;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace MvvmCross.WPF.View1.ViewModels
{
    public class NestedViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public NestedViewModel(IMvxNavigationService navigationService)
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