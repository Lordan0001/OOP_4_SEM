using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rock_shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void TextBlock_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.ShowWeAreSongs();
        }


        private void TextBlock_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.ShowHeavenSongs();
        }

        private void TextBlock_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.ShowThePaleSongs();
        }
        private void TextBlock_PreviewMouseDown_4(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.ShowVilianSongs();
        }
        private void TextBlock_PreviewMouseDown_5(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.ShowTheHighEndSongs();
        }
        private void TextBlock_PreviewMouseDown_6(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.ShowEatMeSongs();
        }



        private void TextBlock_Bracelet(object sender, MouseButtonEventArgs e)
        {
            BraceletWindow braceletWindow = new BraceletWindow();
            braceletWindow.Show();
        }

        private void TextBlock_Ring(object sender, MouseButtonEventArgs e)
        {
            RingsWindow ringsWindow = new RingsWindow();
            ringsWindow.Show();
        }

        private void TextBlock_Poster(object sender, MouseButtonEventArgs e)
        {
            PostersWindow postersWindow = new PostersWindow();
            postersWindow.Show();
        }
    }
}
