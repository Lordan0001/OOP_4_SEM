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
using System.Windows.Shapes;

namespace Rock_shop
{
    /// <summary>
    /// Логика взаимодействия для RingsWindow.xaml
    /// </summary>
    public partial class RingsWindow : Window
    {
        public RingsWindow()
        {
            InitializeComponent();

            InitRings();


        }

        public void InitRings()
        {
            Rings ring1 = new Rings("Череп с узорами", 25, "Индийская. В ожерелье богини Кали насчитывают 50 мертвых голов.");
            Name1.Text = ring1.productName;
            Price1.Text = ring1.productPrice.ToString() + " руб.";
            //Desc1.Text = ring1.shortDescription;


            Rings ring2 = new Rings("Череп с цветами", 25, "Финикийская. Довольно часто богиню плодородия и урожая Иштар изображали, стоящей на груде скелетов");
            Name2.Text = ring2.productName;
            Price2.Text = ring2.productPrice.ToString() + " руб.";

            Rings ring3 = new Rings("Череп", 25, "Древнеегипетская. Одна из самых заметных богинь в античном пантеоне Исида изображается в окружении мертвых голов. Кажется, будто она беседует с ними.");
            Name3.Text = ring3.productName;
            Price3.Text = ring3.productPrice.ToString() + " руб.";

            Rings ring4 = new Rings("Череп стальной", 25, "Древнегреческая. Согласно мифам, Афина появилась на свет из расколотой головы Зевса.");
            Name4.Text = ring4.productName;
            Price4.Text = ring4.productPrice.ToString() + " руб.";

            Rings ring5 = new Rings("Череп круг", 25, "Скандинавская.На украшениях и доспехах воинов часто рисовали черепа.");
            Name5.Text = ring5.productName;
            Price5.Text = ring5.productPrice.ToString() + " руб.";

            Rings ring6 = new Rings("Череп с плоский", 25, "Кельтская. Древние жители Британии считали, что после смерти человека, голова продолжает жить в потустороннем мире и превращается в некое подобие божества");
            Name6.Text = ring6.productName;
            Price6.Text = ring6.productPrice.ToString() + " руб.";
        }

        private void Image_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            Rings ring1 = new Rings("Череп с узорами", 25, "Индийская. В ожерелье богини Кали насчитывают 50 мертвых голов.");
            Desc1.Text = ring1.shortDescription;
        }

        private void Image_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            Rings ring2 = new Rings("Череп с цветами", 25, "Финикийская. Довольно часто богиню плодородия и урожая Иштар изображали, стоящей на груде скелетов");
            Desc1.Text = ring2.shortDescription;
        }

        private void Image_MouseDown3(object sender, MouseButtonEventArgs e)
        {
            Rings ring3 = new Rings("Череп", 25, "Древнеегипетская. Одна из самых заметных богинь в античном пантеоне Исида изображается в окружении мертвых голов. Кажется, будто она беседует с ними.");
            Desc1.Text = ring3.shortDescription;
        }

        private void Image_MouseDown4(object sender, MouseButtonEventArgs e)
        {
            Rings ring4 = new Rings("Череп стальной", 25, "Древнегреческая. Согласно мифам, Афина появилась на свет из расколотой головы Зевса.");
            Desc1.Text = ring4.shortDescription;

        }

        private void Image_MouseDown5(object sender, MouseButtonEventArgs e)
        {
            Rings ring5 = new Rings("Череп круг", 25, "Скандинавская.На украшениях и доспехах воинов часто рисовали черепа.");
            Desc1.Text = ring5.shortDescription;
        }

        private void Image_MouseDown6(object sender, MouseButtonEventArgs e)
        {
            Rings ring6 = new Rings("Череп с плоский", 25, "Кельтская. Древние жители Британии считали, что после смерти человека, голова продолжает жить в потустороннем мире и превращается в некое подобие божества");
            Desc1.Text = ring6.shortDescription;
        }
    }
}
