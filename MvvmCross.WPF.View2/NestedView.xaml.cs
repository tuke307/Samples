using MvvmCross.Platforms.Wpf.Views;

namespace MvvmCross.WPF.View2
{
    /// <summary>
    /// Interaction logic for NestedView.xaml
    /// </summary>
    public partial class NestedView : MvxWpfView<ViewModels.NestedViewModel>
    {
        public NestedView()
        {
            InitializeComponent();
        }
    }
}