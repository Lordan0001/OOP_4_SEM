using SwitchingViewsMVVM.Week;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace SwitchingViewsMVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        WeekContext db;
        public HomeView()
        {
            InitializeComponent();
            db = new WeekContext();

            DateTime dateTime;
            dateTime = DateTime.Now;

            string NowDay = dateTime.DayOfWeek.ToString();


            // db.Mondays.Load();
            //WeekGrid.ItemsSource = db.Mondays.Local.ToBindingList();

            List<string> Days = new List<string> { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            WeekComboBox.ItemsSource = Days;
            WeekComboBox.SelectedItem = "Понедельник";

            switch (NowDay)
            {
                case "Monday":
                    db.Mondays.Load();
                    WeekGrid.ItemsSource = db.Mondays.Local.ToBindingList(); break;
                case "Tuesdays":
                    db.Tuesdays.Load();
                    WeekGrid.ItemsSource = db.Tuesdays.Local.ToBindingList(); break;

                case "Wednesday":
                    db.Wednesdays.Load();
                    WeekGrid.ItemsSource = db.Wednesdays.Local.ToBindingList(); break;
                case "Thursday":
                    db.Thursdays.Load();
                    WeekGrid.ItemsSource = db.Thursdays.Local.ToBindingList(); break;
                case "Friday":
                    db.Fridays.Load();
                    WeekGrid.ItemsSource = db.Fridays.Local.ToBindingList(); break;
                case "Saturday":
                    db.Saturdays.Load();
                    WeekGrid.ItemsSource = db.Saturdays.Local.ToBindingList(); break;

                default:
                    break;
            }


        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {

            string Day;

            Day = WeekComboBox.SelectedItem.ToString();

            switch (Day)
            {
                case "Понедельник":
                    db.Mondays.Load();
                    WeekGrid.ItemsSource = db.Mondays.Local.ToBindingList(); break;
                case "Вторник":
                    db.Tuesdays.Load();
                    WeekGrid.ItemsSource = db.Tuesdays.Local.ToBindingList(); break;

                case "Среда":
                    db.Wednesdays.Load();
                    WeekGrid.ItemsSource = db.Wednesdays.Local.ToBindingList(); break;
                case "Четверг":
                    db.Thursdays.Load();
                    WeekGrid.ItemsSource = db.Thursdays.Local.ToBindingList(); break;
                case "Пятница":
                    db.Fridays.Load();
                    WeekGrid.ItemsSource = db.Fridays.Local.ToBindingList(); break;
                case "Суббота":
                    db.Saturdays.Load();
                    WeekGrid.ItemsSource = db.Saturdays.Local.ToBindingList(); break;

                default:
                    break;
            }
        }
    }
}
