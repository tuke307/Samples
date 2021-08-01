using MvvmCross.Platforms.Wpf.Views;
using Mvx.Wpf.ItemsPresenter;

namespace MvvmCross.WPF.View2
{
    /// <summary>
    /// Interaction logic for Tab2View.xaml
    /// </summary>
    [MvxWpfPresenter("TabRegion", mvxViewPosition.NewOrExsist)]
    public partial class Tab2View : MvxWpfView<ViewModels.Tab2ViewModel>
    {
        public Tab2View()
        {
            InitializeComponent();
        }
    }
}