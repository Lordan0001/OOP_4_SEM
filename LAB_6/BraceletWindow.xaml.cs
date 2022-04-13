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
    /// Логика взаимодействия для BraceletWindow.xaml
    /// </summary>
    public partial class BraceletWindow : Window
    {
        public BraceletWindow()
        {
            InitializeComponent();

            InitBracelets();
        }


        public void InitBracelets()
        {
            Bracelet bracelet1 = new Bracelet("Браслет стальной", 59, "Финикийская. Довольно часто богиню плодородия и урожая Иштар изображали, стоящей на груде скелетов.");
            Name1.Text = bracelet1.productName;
            Price1.Text = bracelet1.productPrice.ToString() + " руб.";

            Bracelet bracelet2 = new Bracelet("Крест", 49, "Древнеегипетская. Одна из самых заметных богинь в античном пантеоне Исида изображается в окружении мертвых голов. Кажется, будто она беседует с ними. ");
            Name2.Text = bracelet2.productName;
            Price2.Text = bracelet2.productPrice.ToString() + " руб.";

            Bracelet bracelet3 = new Bracelet("Черепа", 79, "Древнегреческая. Согласно мифам, Афина появилась на свет из расколотой головы Зевса.");
            Name3.Text = bracelet3.productName;
            Price3.Text = bracelet3.productPrice.ToString() + " руб.";

            Bracelet bracelet4 = new Bracelet("Череп красный", 79, "Скандинавская. На украшениях и доспехах воинов часто рисовали черепа.");
            Name4.Text = bracelet4.productName;
            Price4.Text = bracelet4.productPrice.ToString() + " руб.";

            Bracelet bracelet5 = new Bracelet("Черепа серебро", 109, "Кельтская. Древние жители Британии считали, что после смерти человека, голова продолжает жить в потустороннем мире и превращается в некое подобие божества.");
            Name5.Text = bracelet5.productName;
            Price5.Text = bracelet5.productPrice.ToString() + " руб.";

            Bracelet bracelet6 = new Bracelet("Черепа платина", 149, "Индийская. В ожерелье богини Кали насчитывают 50 мертвых голов.");
            Name6.Text = bracelet6.productName;
            Price6.Text = bracelet6.productPrice.ToString() + " руб.";
        }

        private void Image_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            Bracelet bracelet1 = new Bracelet("Браслет стальной", 59, "Финикийская. Довольно часто богиню плодородия и урожая Иштар изображали, стоящей на груде скелетов.");
            Desc1.Text = bracelet1.shortDescription;
        }

        private void Image_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            Bracelet bracelet2 = new Bracelet("Крест", 49, "Древнеегипетская. Одна из самых заметных богинь в античном пантеоне Исида изображается в окружении мертвых голов. Кажется, будто она беседует с ними. ");
            Desc1.Text = bracelet2.shortDescription;
        }

        private void Image_MouseDown3(object sender, MouseButtonEventArgs e)
        {
            Bracelet bracelet3 = new Bracelet("Черепа", 79, "Древнегреческая. Согласно мифам, Афина появилась на свет из расколотой головы Зевса.");
            Desc1.Text = bracelet3.shortDescription;
        }

        private void Image_MouseDown4(object sender, MouseButtonEventArgs e)
        {
            Bracelet bracelet4 = new Bracelet("Череп красный", 79, "Скандинавская. На украшениях и доспехах воинов часто рисовали черепа.");
            Desc1.Text = bracelet4.shortDescription;
        }

        private void Image_MouseDown5(object sender, MouseButtonEventArgs e)
        {
            Bracelet bracelet5 = new Bracelet("Черепа серебро", 109, "Кельтская. Древние жители Британии считали, что после смерти человека, голова продолжает жить в потустороннем мире и превращается в некое подобие божества.");
            Desc1.Text = bracelet5.shortDescription;
        }

        private void Image_MouseDown6(object sender, MouseButtonEventArgs e)
        {
            Bracelet bracelet6 = new Bracelet("Черепа платина", 149, "Индийская. В ожерелье богини Кали насчитывают 50 мертвых голов.");
            Desc1.Text = bracelet6.shortDescription;
        }
    }
}
