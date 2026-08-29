using RxdotNetDemo.ViewModels;
using System.Windows;

namespace RxdotNetDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}