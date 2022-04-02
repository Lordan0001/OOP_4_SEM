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
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace LAB_2
{
    public partial class Form3 : Form
    {
       private TrueDate trueDate;
        public Form3( TrueDate newTrueDate)
        {
            InitializeComponent();
            trueDate = newTrueDate;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstNameSelected = FirstNameBox.Text;
           
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }
            Regex regex = new Regex(firstNameSelected);
            // p1 = p1.Where(p => regex.IsMatch(p.FirstName)).ToList();
            p1 = p1.Where(p => p.FirstName == firstNameSelected || regex.IsMatch(p.FirstName)).ToList();


            dataGridView1.DataSource = p1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            string secondNameSelected = SecondNameBox.Text;
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }
            Regex regex = new Regex(secondNameSelected);
            // p1 = p1.Where(p => regex.IsMatch(p.FirstName)).ToList();
      
            p1 = p1.Where(p => p.SecondName == secondNameSelected || regex.IsMatch(p.SecondName)).ToList();



            dataGridView1.DataSource = p1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ThirdNameSelected = ThirdNameBox.Text;
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }
            Regex regex = new Regex(ThirdNameSelected);
            // p1 = p1.Where(p => regex.IsMatch(p.FirstName)).ToList();

            p1 = p1.Where(p => p.ThirdName == ThirdNameSelected || regex.IsMatch(p.ThirdName)).ToList();



            dataGridView1.DataSource = p1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Specselected = SpecBox.Text;
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }
            Regex regex = new Regex(Specselected);
            // p1 = p1.Where(p => regex.IsMatch(p.FirstName)).ToList();

            p1 = p1.Where(p => p.Specialinost == Specselected || regex.IsMatch(p.ThirdName)).ToList();



            dataGridView1.DataSource = p1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string CursSelected = CursBox.Text;
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }
            Regex regex = new Regex(CursSelected);
            // p1 = p1.Where(p => regex.IsMatch(p.FirstName)).ToList();

            p1 = p1.Where(p => p.Curs == CursSelected || regex.IsMatch(p.Curs)).ToList();



            dataGridView1.DataSource = p1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string BallSelected = BallBox.Text;
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }
            Regex regex = new Regex(BallSelected);
            // p1 = p1.Where(p => regex.IsMatch(p.FirstName)).ToList();

            p1 = p1.Where(p => p.Ocenka == BallSelected || regex.IsMatch(p.Ocenka)).ToList();



            dataGridView1.DataSource = p1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }
            //Regex regex = new Regex(selected);
            // p1 = p1.Where(p => regex.IsMatch(p.FirstName)).ToList();

            /* p1 = p1.Where(p => p.Ocenka == BallSelected).ToList();*/
            string value = DiapozonBox.Text;
            int value2 = int.Parse(value);
            int counter = 0;
            List<Student> p2 = new List<Student>();
            foreach (var item in p1)
            {
                ++counter;
                p2.Add(item);
                if (counter == value2)
                {
                    break;
                }
              
            }
            dataGridView1.DataSource = p2;



        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }

            List<Student> p2 = new List<Student>();

            p1.Sort(delegate (Student us1, Student us2)
            { return us1.Curs.CompareTo(us2.Curs); });

            dataGridView1.DataSource = p1;


            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\SortCurs.xml", FileMode.Create, FileAccess.Write))
            {

                serial.Serialize(fs, p1);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }

           
            /*          p2 = from Curs in p1
                           orderby p1.Curs
                           select p1.Curs;*/
            p1.Sort(delegate (Student us1, Student us2)
            { return us1.Group.CompareTo(us2.Group); });
            //p1 = p1.Where(p => p.Curs).ToList();

            dataGridView1.DataSource = p1;

            using(FileStream fs = new FileStream(Environment.CurrentDirectory + "\\SortGroup.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<Student> p1 = new List<Student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Student>;
            }


            /*          p2 = from Curs in p1
                           orderby p1.Curs
                           select p1.Curs;*/
            p1.Sort(delegate (Student us1, Student us2)
            { return us1.Age.CompareTo(us2.Age); });
            //p1 = p1.Where(p => p.Curs).ToList();

            dataGridView1.DataSource = p1;
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\SortAge.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
            }
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

            dateLabel.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
           /* Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        */


        }
     /*   void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }*/
    }
}
