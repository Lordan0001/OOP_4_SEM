using SwitchingViewsMVVM.Week;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Controls;


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

            FillStudentProfile();

        }


        public void FillStudentProfile()
        {
            db = new WeekContext();
            db.Students.Load();
            List<Student> studentList = new List<Student>();
            foreach (var item in db.Students)
            {
                studentList.Add(item);
            }



            int index = 999;

            foreach (var item in studentList)
            {
                if (item.Surname == EnterView.StudentSurname)
                {
                    index = studentList.IndexOf(item);
                }

            }


            Student student1 = new Student();
            student1 = studentList[index];

            SurnameLabel.Content = student1.Surname;
            NameLabel.Content = student1.Name;
            PatronymicLabel.Content = student1.Patronymic;
            GroupLabel.Content = student1.Group;
            CourseLabel.Content = student1.Course;
        }






    }
}
