﻿using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.WPF.View2.Region;

namespace MvvmCross.WPF.View2
{
    /// <summary>
    /// Interaction logic for Tab1View.xaml
    /// </summary>
    [MvxWpfPresenter("TabRegion", mvxViewPosition.NewOrExsist)]
    public partial class Tab1View : MvxWpfView
    {
        public Tab1View()
        {
            InitializeComponent();
        }
    }
}