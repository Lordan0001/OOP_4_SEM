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
    public partial class Form2 : Form
    {
        private TrueDate ClosedForm;
        public Form2(TrueDate form1)
        {
            InitializeComponent();
            ClosedForm = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adres adres = new Adres();

            adres.City = CityBox.Text;
            adres.Flat = FlatBox.Text;
            adres.Index = IndexBox.Text;
            adres.Street = StreetBox.Text;
            adres.House = HouseBox.Text;
            //
            List<Adres> p1 = new List<Adres>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Adres>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\AdresFile.xml", FileMode.Open, FileAccess.Read))
            {
                if(fs.Length ==  0)
                {
                    goto link1;
                }
                else
                {
                    p1 = serial.Deserialize(fs) as List<Adres>;
                }
               
            }
            //


            link1:
          /*  List<Adres> p1 = new List<Adres>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Adres>));*/
            p1.Add(adres);
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\AdresFile.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Adres> p1 = new List<Adres>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Adres>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\AdresFile.xml", FileMode.Open, FileAccess.Read))
            {
                p1 = serial.Deserialize(fs) as List<Adres>;
            }
            AdresGrid.DataSource = p1;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosedForm.Close();
            Application.Exit();

        }
    }
}
