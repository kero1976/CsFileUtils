using FileUtils.WPF.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace FileUtils.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
