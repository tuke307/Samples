using MvvmCross.Platforms.Wpf.Views;
using Mvx.Wpf.ItemsPresenter;

namespace MvvmCross.WPF.View2
{
    /// <summary>
    /// Interaction logic for NestedView.xaml
    /// </summary>
    [MvxWpfPresenter("MainWindowRegion")]
    public partial class NestedView : MvxWpfView<ViewModels.NestedViewModel>
    {
        public NestedView()
        {
            InitializeComponent();
        }
    }
}