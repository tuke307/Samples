using MvvmCross.ViewModels;
using System.Windows.Controls;

namespace MvvmCross.WPF.View1
{
    /// <summary>
    /// Interaction logic for NestedView.xaml
    /// </summary>
    public partial class NestedView : UserControl
    {
        public ViewModels.NestedViewModel ViewModel { get; }

        public NestedView()
        {
            InitializeComponent();

            // when viewmodel already created
            if (Mvx.IoCProvider.TryResolve<ViewModels.NestedViewModel>(out var someViewModel))
            {
                ViewModel = someViewModel;
                DataContext = ViewModel;
                return;
            }

            // creating viewmodel
            var _viewModelLoader = Mvx.IoCProvider.Resolve<IMvxViewModelLoader>();
            var request = new MvxViewModelInstanceRequest(typeof(ViewModels.NestedViewModel));
            request.ViewModelInstance = _viewModelLoader.LoadViewModel(request, null);
            ViewModel = request.ViewModelInstance as ViewModels.NestedViewModel;
            DataContext = ViewModel;

            Mvx.IoCProvider.RegisterSingleton<ViewModels.NestedViewModel>(ViewModel);
        }
    }
}