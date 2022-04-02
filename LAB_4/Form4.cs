using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LAB_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string str1;
            string str2;
            Human human = new Human(new Enrollee());
            str1 = human.HisStatus();
            str2 = human.HisWanna();
            EnStatus.Text = str1;
            EnWannaBox.Text = str2;
            /* BackColor = Color.Red;
             Font = new Font("Times New Roman", 10, FontStyle.Bold);*/
      
            BackColor = Singleton.SiColor;
            Font = Singleton.SiFont;
        }

        private void EnsaveButton_Click(object sender, EventArgs e)
        {
            Enrollee enrollee = new Enrollee();
            enrollee.EnSecondName = EnSecondNameBox.Text;
            enrollee.EnFirstName = EnFirstNameBox.Text;
            enrollee.EnThirdName = EnThirdNameBox.Text;
            enrollee.EnSex = EnSexBox.Text;
            enrollee.EnBirthDate = EndateTimePicker1.Text;
            enrollee.EnAge = EnAgeBox.Text;

            var context = new ValidationContext(enrollee);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(enrollee, context, results, true))
            {
                // Console.WriteLine("Не удалось создать объект User");

                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                //Console.WriteLine();
            }


            //
            List<Enrollee> p1 = new List<Enrollee>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Enrollee>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\EnrolleeFile.xml", FileMode.Open, FileAccess.Read))
            {
                if (fs.Length == 0)
                {
                    goto link2;
                }
                else
                {
                    p1 = serial.Deserialize(fs) as List<Enrollee>;
                }

            }
        //

        link2:
            p1.Add(enrollee);



            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\EnrolleeFile.xml", FileMode.Create, FileAccess.Write))
            {

                serial.Serialize(fs, p1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Enrollee> p1 = new List<Enrollee>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Enrollee>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\EnrolleeFile.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Enrollee>;
            }

            EnGrid.DataSource = p1;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
