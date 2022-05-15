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
        public static int StudentNumber = 0;



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (log.Text == "Admin" && pass.Text == "1111")
            {

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                EnterWindow.CloseEnter();
                StudentNumber = 1;

            }
            else if (log.Text == "Sdmin" && pass.Text == "1111")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                EnterWindow.CloseEnter();
                StudentNumber = 2;
            }
            else
            {
                MessageBox.Show("Проверьте пароль или логин");
            }
        }
    }
}
