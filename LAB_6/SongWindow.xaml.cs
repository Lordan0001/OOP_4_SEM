using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
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
            // ShowHeavenSongs();
            // ShowWeAreSongs();
            //ShowThePaleSongs();

            // ShowVilianSongs();
            //TheHighEndSongs();
            //SaveSongs();
           // EatMeSongs();
        }
        public string GetName(string str)
        {
            return str;
        }
        public void ShowWeAreSongs()
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\We_are_Songs.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }
        public void ShowThePaleSongs()
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\The_Pale_Songs.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }
        public void ShowHeavenSongs()
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Heaven_Songs.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }
        public void ShowVilianSongs()
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Born_Villain_Songs.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }
        public void TheHighEndSongs()
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\The_High_End_Songs.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }
        public void EatMeSongs()
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Eat_Me.xml", FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }
        public void SaveSongs()
        {
            List<Album> p1 = new List<Album>();
         /*     Album album1 = new Album("Red Black and Blue", "5:03", "We Are Chaos");*/

            /*p1.Add(album1);*/


            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\NAME.xml", FileMode.Create, FileAccess.Write))
            {

                serial.Serialize(fs, p1);
            }
        }
    }

}

