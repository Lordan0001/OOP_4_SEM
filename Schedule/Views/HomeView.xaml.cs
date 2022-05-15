using SwitchingViewsMVVM.Week;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SwitchingViewsMVVM.Views
{

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


            List<string> Days = new List<string> { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            WeekComboBox.ItemsSource = Days;
            WeekComboBox.SelectedItem = "Понедельник";

            List<string> FindVlaue = new List<string> { "По имени", "По типу", "По номеру" };
            ComboFind.ItemsSource = FindVlaue; ComboFind.SelectedItem = "По имени";

            WeekContext userContext = new WeekContext();


            db.Lessons.Load();
            IQueryable<Lesson> LessonsList;


            switch (NowDay)
            {
                case "Monday":
                LessonsList = userContext.Lessons
                        .Where(c => c.When == "Понедельник")
                        .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;


                case "Tuesdays":

                    LessonsList = userContext.Lessons
                      .Where(c => c.When == "Вторник")
                       .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;


                case "Wednesday":

                    LessonsList = userContext.Lessons
                        .Where(c => c.When == "Среда")
                        .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;


                case "Thursday":
                    LessonsList = userContext.Lessons
                       .Where(c => c.When == "Четверг")
                        .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;


                case "Friday":
                    LessonsList = userContext.Lessons
                        .Where(c => c.When == "Пятница")
                         .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;


                case "Saturday":
                    LessonsList = userContext.Lessons
                     .Where(c => c.When == "Суббота")
                     .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;

                default:
                    LessonsList = userContext.Lessons
                    .Where(c => c.When == "Воскресенье")
                    .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;
            
            }



        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {

            string Day;

            Day = WeekComboBox.SelectedItem.ToString();
            WeekContext userContext = new WeekContext();
            db.Lessons.Load();
            IQueryable<Lesson> LessonsList;

            switch (Day)
            {
                case "Понедельник":
                    LessonsList= userContext.Lessons
                        .Where(c => c.When == "Понедельник")
                        .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;

                case "Вторник":
                    LessonsList = userContext.Lessons
                        .Where(c => c.When == "Вторник")
                        .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;

                case "Среда":
                    LessonsList = userContext.Lessons
                         .Where(c => c.When == "Среда")
                         .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;

                case "Четверг":
                    LessonsList = userContext.Lessons
                           .Where(c => c.When == "Четверг")
                          .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;
                case "Пятница":
                    LessonsList = userContext.Lessons
                        .Where(c => c.When == "Пятница")
                          .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;
                case "Суббота":
                    LessonsList = userContext.Lessons
                      .Where(c => c.When == "Суббота")
                      .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;

                default:
                    LessonsList = userContext.Lessons
                    .Where(c => c.When == "Воскресенье")
                    .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;
            }
        }

        private void NameButton_Click(object sender, RoutedEventArgs e)
        {
            WeekContext userContext = new WeekContext();


           // db.Lessons.Load();
            IQueryable<Lesson> LessonsList;
            string Selected = ComboFind.SelectedItem.ToString();
            switch (Selected)
            {
                case "По имени":
                    LessonsList = userContext.Lessons
                        .Where(c => c.Name == FindBox.Text)
                        .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;
                case "По типу":
                    LessonsList = userContext.Lessons
                        .Where(c => c.Type == FindBox.Text)
                        .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;
                case "По номеру":
                    LessonsList = userContext.Lessons
                        .Where(c => c.Number == FindBox.Text)
                        .Select(c => c);
                    WeekGrid.ItemsSource = LessonsList.ToList(); break;
                default:
                    break;
            }
        }
    }
}
