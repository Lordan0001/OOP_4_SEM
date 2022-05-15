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

            MainWindow mainWindow = new MainWindow();
            switch (pass.Text)
            {
                case "14005011":                 
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 0;break;

                case "14005012":
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 1; break;

                case "14005013":
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 2; break;

                case "14005014":
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 3; break;

                case "14005015":
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 4; break;

                case "14005016":
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 5; break;

                case "14005017":
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 6; break;

                case "14005018":
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 7; break;

                case "14005019":
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    StudentNumber = 8; break;

                default:
                    MessageBox.Show("Проверьте введённый номер студенческого билета");
                    break;
            }



        }
    }
}
