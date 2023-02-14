using PRV.Task._1.Core;
using PRV.Task._1.View.Pages;
using System.Windows;

namespace PRV.Task._1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());

        }
    }
}
