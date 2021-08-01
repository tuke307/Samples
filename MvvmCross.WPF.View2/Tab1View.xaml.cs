using MvvmCross.Platforms.Wpf.Views;
using Mvx.Wpf.ItemsPresenter;

namespace MvvmCross.WPF.View2
{
    /// <summary>
    /// Interaction logic for Tab1View.xaml
    /// </summary>
    [MvxWpfPresenter("TabRegion", mvxViewPosition.NewOrExsist)]
    public partial class Tab1View : MvxWpfView<ViewModels.Tab1ViewModel>
    {
        public Tab1View()
        {
            InitializeComponent();
        }
    }
}