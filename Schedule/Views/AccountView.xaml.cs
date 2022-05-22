using SwitchingViewsMVVM.Week;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace SwitchingViewsMVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для AccountView.xaml
    /// </summary>
    public partial class AccountView : UserControl
    {
        WeekContext db;
        public AccountView()
        {
            InitializeComponent();

            db = new WeekContext();
            db.Professor.Load();
            PGrid.ItemsSource = db.Professor.Local.ToBindingList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WeekContext userContext = new WeekContext();
            db.Professor.Load();
            IQueryable<Professor> LessonsList;
            LessonsList = userContext.Professor
              .Where(c => c.Lesson == FindBox.Text.ToString())
              .Select(c => c);
                PGrid.ItemsSource = LessonsList.ToList();
    
        }

        private void PositionButton_Click(object sender, RoutedEventArgs e)
        {
            WeekContext userContext = new WeekContext();
            db.Professor.Load();
            IQueryable<Professor> LessonsList;
            LessonsList = userContext.Professor
              .Where(c => c.Position == FindBox.Text.ToString())
              .Select(c => c);
            PGrid.ItemsSource = LessonsList.ToList();
        }

        private void NameButton_Click(object sender, RoutedEventArgs e)
        {
            WeekContext userContext = new WeekContext();
            db.Professor.Load();
            IQueryable<Professor> LessonsList;
            LessonsList = userContext.Professor
              .Where(c => c.Name == FindBox.Text.ToString())
              .Select(c => c);
            PGrid.ItemsSource = LessonsList.ToList();

        }
    }
}
