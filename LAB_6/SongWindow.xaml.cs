using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace Rock_shop
{

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            // ShowHeavenSongs();
            // ShowWeAreSongs();
            //ShowThePaleSongs();

            // ShowVilianSongs();
            //ShowTheHighEndSongs();
          //  SaveSongs();
            // ShowEatMeSongs();
        }
       public void SelSongs(string dir)
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

        }
        public void DesSongs(string dir)
        {
            string directory = dir;
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + directory, FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }
        public string ChooseDirectory()
        {
            string directory;
            if (SongAlbum.Text == "We are Chaos")
            {
               return directory = "\\We_are_Songs.xml";
            }
            else if (SongAlbum.Text == "Heaven Upside Down")
            {
                return directory = "\\Heaven_Songs.xml";
            }
            else if (SongAlbum.Text == "The Pale Emperor")
            {
                return directory = "\\The_Pale_Songs.xml";
            }
            else if (SongAlbum.Text == "Born Villain")
            {
                return directory = "\\Born_Villain_Songs.xml";
            }
            else if (SongAlbum.Text == "The High End of Low")
            {
                return directory = "\\The_High_End_Songs.xml";
            }
            else if (SongAlbum.Text == "Eat Me, Drink Me")
            {
                return directory = "\\Eat_Me.xml";
            }
            return "Test";
        }
        public void ShowWeAreSongs()
        {
            DesSongs("\\We_are_Songs.xml");
           
        }
        public void ShowThePaleSongs()
        {
            DesSongs("\\The_Pale_Songs.xml");
           
        }
        public void ShowHeavenSongs()
        {
            DesSongs("\\Heaven_Songs.xml");
           
        }
        public void ShowVilianSongs()
        {
            DesSongs("\\Born_Villain_Songs.xml");
           
        }
        public void ShowTheHighEndSongs()
        {
            DesSongs("\\The_High_End_Songs.xml");
          
        }
        public void ShowEatMeSongs()
        {
            DesSongs("\\Eat_Me.xml");
           
        }
        public void SaveSongs()
        {
            List<Album> p1 = new List<Album>();
            /*     Album album1 = new Album("Red Black and Blue", "5:03", "We Are Chaos");*/

            /*p1.Add(album1);*/

       


            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Name.xml", FileMode.Create, FileAccess.Write))
            {

                serial.Serialize(fs, p1);
            }
        }

        private void AddSong(object sender, RoutedEventArgs e)
        {
            Album album = new Album();
            album.SongName = SongName.Text;
            album.SongDuration = SongDuration.Text;
            album.FromAlbum = SongAlbum.Text;



            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            string directory = ChooseDirectory();

           



            using (FileStream fs = new FileStream(Environment.CurrentDirectory + directory, FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
                
            }


            p1.Add(album);
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + directory, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
            }



        }

        private void ShowSong(object sender, RoutedEventArgs e)
        {
            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));
            string directory = ChooseDirectory();
         
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + directory, FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }

            SondGridView.ItemsSource = p1;
        }

        private void DeleteSong(object sender, RoutedEventArgs e)
        {
            string directory = ChooseDirectory();
            string chosenName = SongName.Text;
            string chosenDuration = SongDuration.Text;

            List<Album> p1 = new List<Album>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Album>));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + directory, FileMode.Open, FileAccess.Read))
            {

                p1 = serial.Deserialize(fs) as List<Album>;
            }
            foreach (var item in p1.ToArray())
            {
                if (item.SongName == chosenName/* || item.SongDuration == chosenDuration*/)
                {
                    p1.Remove(item);
                }

            }
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + directory, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
            }
        }
    }

}

