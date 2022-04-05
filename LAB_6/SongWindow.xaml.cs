using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Rock_shop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            ShowSongs();
        }
        public void ShowSongs()
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Songs.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }
        public void SaveSongs()
        {
            List<Album> p1 = new List<Album>();
            Album album1 = new Album("Red Black and Blue", "5:03", "We Are Chaos");
            Album album2 = new Album("We Are Chaos", "4:00", "We Are Chaos");
            Album album3 = new Album("Don't Chase the Dead", "4:17", "We Are Chaos");

            Album album4 = new Album("Paint You with My Love", "4:29", "We Are Chaos");
            Album album5 = new Album("Half-Way, One Step Forward", "3:16", "We Are Chaos");
            Album album6 = new Album("Infinite Darkness", "4:15", "We Are Chaos");
            Album album7 = new Album("Perfume", "3:33", "We Are Chaos");
            Album album8 = new Album("Keep My Head Together", "3:49", "We Are Chaos");
            Album album9 = new Album("Solve Coagula", "4:22", "We Are Chaos");
            Album album10 = new Album("Broken Needle", "5:23", "We Are Chaos");


            p1.Add(album1);
            p1.Add(album2);
            p1.Add(album3);
            p1.Add(album4);
            p1.Add(album5);
            p1.Add(album6);
            p1.Add(album7);
            p1.Add(album8);
            p1.Add(album9);
            p1.Add(album10);

            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Songs.xml", FileMode.Create, FileAccess.Write))
            {

                serial.Serialize(fs, p1);
            }
        }
    }

}

