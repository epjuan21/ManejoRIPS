using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ManejoRIPS
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.mainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void mnuSalir_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void mnuPage1_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Page1());
        }

        private void mnuPage2_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Page2());
        }

        private void mnuPage3_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Page3());
        }
    }
}
