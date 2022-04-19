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

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {

            BraceleteBlock.TextDecorations = TextDecorations.Underline;
          
        }

        private void BraceleteBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            BraceleteBlock.TextDecorations = null;

        }

        private void TextBlock_MouseEnter_1(object sender, MouseEventArgs e)
        {
            RingBlock.TextDecorations = TextDecorations.Underline;
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            RingBlock.TextDecorations = null;
        }

        private void TextBlock_MouseEnter_2(object sender, MouseEventArgs e)
        {
            PosterBlock.TextDecorations = TextDecorations.Underline;
        }

        private void TextBlock_MouseLeave_1(object sender, MouseEventArgs e)
        {
            PosterBlock.TextDecorations = null;
        }
        public static int Count = 1;
        private void Language_Click(object sender, RoutedEventArgs e)
        {

       /*     int count = 1;*/
        
            int two = 2;
            Count++;
            if (Count % two ==0)
            {
                Language.Content = "Eng";
                First.Text = "Rock-Bastion";
                More.Text = "More";
                BraceleteBlock.Text = "Bracelets";
                RingBlock.Text = "Rings";
                PosterBlock.Text = "Posters";
                MainCategories.Text = "Main categories";
            }

            else
            {
                Language.Content = "Rus";
                First.Text = "Рок-Бастион";
                More.Text = "Дополнительные";
                BraceleteBlock.Text = "Браслеты";
                RingBlock.Text = "Кольца";
                PosterBlock.Text = "Постеры";
                MainCategories.Text = "Основные категории";
            }





        }
    }
}
