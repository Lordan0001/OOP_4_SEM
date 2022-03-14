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

namespace LAB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
          
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

            student.BirtDate = BirthdateBox.Text;

            List <Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));
            p1.Add(student);
            using(FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Create, FileAccess.Write))
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
    }
}
