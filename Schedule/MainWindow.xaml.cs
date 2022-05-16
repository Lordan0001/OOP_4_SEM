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
using SwitchingViewsMVVM.ViewModels;

namespace SwitchingViewsMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            DataContext = new MainViewModel();


        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Label1.Visibility = Visibility.Hidden;
            Label2.Visibility = Visibility.Hidden;
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Developer: Bialitski V.D\nVersion: 1.0");
        }
    }
}
