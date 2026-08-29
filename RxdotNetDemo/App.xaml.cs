using Microsoft.Extensions.DependencyInjection;
using RxdotNetDemo.ViewModels;
using System.Windows;

namespace RxdotNetDemo
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            InitContainer();

            var mw = ServiceProvider.GetRequiredService<MainWindow>();
            mw.Show();

        }

        private void InitContainer()
        {
            var container = new ServiceCollection();

            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainWindowViewModel>();

            ServiceProvider = container.BuildServiceProvider();
        }
    }

}
