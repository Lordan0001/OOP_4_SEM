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
using SwitchingViewsMVVM.Week;

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
            db.Mondays.Load();
            WeekGrid.ItemsSource = db.Mondays.Local.ToBindingList();
        }
    }
}
