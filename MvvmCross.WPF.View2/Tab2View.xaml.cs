using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.WPF.View2.Region;

namespace MvvmCross.WPF.View2
{
    /// <summary>
    /// Interaction logic for Tab2View.xaml
    /// </summary>
    [MvxWpfPresenter("TabRegion", mvxViewPosition.NewOrExsist)]
    public partial class Tab2View : MvxWpfView
    {
        public Tab2View()
        {
            InitializeComponent();
        }
    }
}