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
using System.Windows.Shapes;

namespace Rock_shop
{
    /// <summary>
    /// Логика взаимодействия для UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        VallidateLogin Val;
        public UserLogin()
        {
            InitializeComponent();
            Val = new VallidateLogin();
            this.DataContext = Val;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (log.Text == "Admin" && pass.Text == "1111")
            {
               
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
        }
    }
}
