using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace MvvmCross.WPF.View2.ViewModels
{
    public class NestedViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public IMvxAsyncCommand ShowTab2ViewModelCommand { get; protected set; }

        public IMvxAsyncCommand ShowTab1ViewModelCommand { get; protected set; }

        public NestedViewModel(IMvxNavigationService navigationService)
        {
            this._navigationService = navigationService;

            this.ShowTab1ViewModelCommand = new MvxAsyncCommand(() => this._navigationService.Navigate<Tab1ViewModel>());
            this.ShowTab2ViewModelCommand = new MvxAsyncCommand(() => this._navigationService.Navigate<Tab2ViewModel>());
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

        /// <summary>
        /// When view is appearing.
        /// </summary>
        public override void ViewAppearing()
        {
            base.ViewAppearing();

            this.ShowTab1ViewModelCommand.Execute();
            this.ShowTab2ViewModelCommand.Execute();
        }
    }
}