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
    /// Логика взаимодействия для ProfileView.xaml
    /// </summary>
    public partial class ProfileView : UserControl
    {
        WeekContext db;

        public ProfileView()
        {
            InitializeComponent();

           


            switch (EnterView.StudentNumber)
            {
                case 1: FillStudentProfile1(); break;
                    case 2: FillStudentProfile2(); break;
                default:
                    break;
            }



        }


        public void FillStudentProfile1()
        {
            db = new WeekContext();
            db.Students.Load();
            List<Student> studentList = new List<Student>();
            foreach (var item in db.Students)
            {
                studentList.Add(item);
            }

            Student student1 = new Student();
            student1 = studentList[0];

            SurnameLabel.Content = student1.Surname;
            NameLabel.Content = student1.Name;
            PatronymicLabel.Content = student1.Patronymic;
            GroupLabel.Content = student1.Group;
            CourseLabel.Content = student1.Course;
        }


        public void FillStudentProfile2()
        {
            db = new WeekContext();
            db.Students.Load();
            List<Student> studentList = new List<Student>();
            foreach (var item in db.Students)
            {
                studentList.Add(item);
            }

            Student student1 = new Student();
            student1 = studentList[1];

            SurnameLabel.Content = student1.Surname;
            NameLabel.Content = student1.Name;
            PatronymicLabel.Content = student1.Patronymic;
            GroupLabel.Content = student1.Group;
            CourseLabel.Content = student1.Course;
        }



    }
}
