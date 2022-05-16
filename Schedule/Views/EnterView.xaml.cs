using SwitchingViewsMVVM.Week;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SwitchingViewsMVVM.Views
{

    public partial class EnterView : UserControl
    {
        WeekContext db;
        public EnterView()
        {
            InitializeComponent();


        }
        public static int StudentNumber = 0;



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            int i = 0;
            db = new WeekContext();
            db.StudentsTickets.Load();
            List<string> PassList = new List<string>();
            foreach (var item in db.StudentsTickets)
            {
                PassList.Add(item.Ticket);
            }


            foreach (var item in PassList)
            {
                i++;
                if (pass.Text == item)
                {
                    mainWindow.Show();
                    EnterWindow.CloseEnter();
                    string Temp = pass.Text;
                    char last = Temp.Last();
                    int ToStudentNumber = last - '0';
                    --ToStudentNumber;

                    StudentNumber = ToStudentNumber; break;
                }
                else if (i == PassList.Count)
                {
                    MessageBox.Show("Проверьте введённый номер студенческого билета");
                }
   

            }




        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                EnterButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

    }
}
