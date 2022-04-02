using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace LAB_2
{
    public partial class TrueDate : Form
    {
       // private TrueDate trueDateObj;
        public TrueDate()
        {
            InitializeComponent();
            //trueDateObj = Tobj;
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
            UserNameAttribute userName = new UserNameAttribute();
            userName.IsValid(student.Curs);
            bool bk = userName.IsValid(student.Curs);
           
            
                MessageBox.Show(
                    "курс должен быть задан 1-4");

        



            student.Group = (int)numericUpDown1.Value;
            
            student.Ocenka = BallBox.Text;

            student.Sex = SexBox.Text;

            student.BirthDate = dateTimePicker1.Text;
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
         


            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Create,FileAccess.Write))
            {
                /*     p1 = serial.Deserialize(fs) as List<Student>;
                     p1.Add(student);
                     serial.Serialize(fs, p1);*/


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
           
            public override bool IsValid(object value)
   
            {

                Student str = value as Student;
               
                int qq = 0;
                qq = Convert.ToInt32(value);
            //  qq = Convert.ToInt32(str);
               
                if (qq > 4 || qq < 1)
                {

                    return false;

                }
                return true;
            }
        }
       
    }
}
