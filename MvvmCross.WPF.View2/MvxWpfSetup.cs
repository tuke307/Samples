namespace MvvmCross.WPF.View2
{
    using MvvmCross.Platforms.Wpf.Presenters;
    using MvvmCross.ViewModels;
    using MvvmCross.WPF.View2.Region;
    using System.Windows.Controls;

    /// <summary>
    /// WPF dotnetframework app start.
    /// </summary>
    /// <typeparam name="TApplication">The type of the application.</typeparam>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Core.MvxWpfSetup{TApplication}" />
    public class MvxWpfSetup<TApplication> : MvvmCross.Platforms.Wpf.Core.MvxWpfSetup<TApplication>
        where TApplication : class, IMvxApplication, new()
    {
        /// <summary>
        /// Creates the view presenter.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        protected override IMvxWpfViewPresenter CreateViewPresenter(ContentControl root)
        {
            return new MvxWpfPresenter(root);
        }
    }
}