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
using SwitchingViewsMVVM;

namespace SwitchingViewsMVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для EnterView.xaml
    /// </summary>
    public partial class EnterView : UserControl
    {
        public EnterView()
        {
            InitializeComponent();


        }




        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (log.Text == "Admin" && pass.Text == "1111")
            {

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            
                
            }
            else
            {
                MessageBox.Show("Проверьте пароль или логин");
            }
        }
    }
}
