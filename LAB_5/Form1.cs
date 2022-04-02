using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LAB_2
{
    public partial class TrueDate : Form
    {
        // private TrueDate trueDateObj;
        public TrueDate()
        {
            InitializeComponent();
            //trueDateObj = Tobj;
            MyWatch.Text = "";
            MyWatch.Enabled = true;
            // MyWatch.Interval = 1000;
            Human st = new Human(new Student());
            string str = st.HisStatus();
             StudentStatus.Text = str;
            string str2 = st.HisWanna();
            StudentWannaBox.Text = str2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MyWatch.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2(this);

            form2.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
 

            student.SecondName = SecondNameBox.Text;

            student.ThirdName = ThirdNameBox.Text;

            student.FirstName = FirstNameBox.Text;

            student.Age = AgeBox.Text;

            student.Specialinost = SpecComboBox.Text;

            student.Curs = CursComboBox.Text;


            student.Group = GroupComboBox.Text;

            student.Ocenka = BallBox.Text;

            student.Sex = SexBox.Text;

            student.BirthDate = dateTimePicker1.Text;
            Student cloneStudent = student.DeepCopy() as Student;
           

            var context = new ValidationContext(student);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(student, context, results, true))
            {
                // Console.WriteLine("Не удалось создать объект User");

                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage); 
                }
                
            }
           

            //
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {
                if (fs.Length == 0)
                {
                    goto link2;
                }
                else
                {
                    p1 = serial.Deserialize(fs) as List<Student>;
                }

            }
        //

        link2:
            p1.Add(student);



            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Create, FileAccess.Write))
            {



                serial.Serialize(fs, p1);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }

            dataGridView1.DataSource = p1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3(this);

            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TrueDate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Student program\nversion: 1.0\nDeveloper: Bialitski Vladislav");
        }
        public class UserNameAttribute : ValidationAttribute
        {
            Student st = new Student();
            Student test1 = new Student();

  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

    
    }
}
