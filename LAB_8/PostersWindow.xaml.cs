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
    /// Логика взаимодействия для PostersWindow.xaml
    /// </summary>
    public partial class PostersWindow : Window
    {
        public PostersWindow()
        {
            InitializeComponent();


            InitPosters();

        }

        public void InitPosters()
        {
            Posters poster1 = new Posters("AC/DC", 20, "Австралийская рок-группа, сформированная в Сиднее в ноябре 1973 года выходцами из Шотландии, братьями Малькольмом и Ангусом Янгами.");
            Name1.Text = poster1.productName;
            Price1.Text = poster1.productPrice.ToString() + " руб.";

            Posters poster2 = new Posters("Arctic Monkeys", 20, "Британская рок-группа, сформированная в 2002 году в Хай Грин, пригороде Шеффилда.");
            Name2.Text = poster2.productName;
            Price2.Text = poster2.productPrice.ToString() + " руб.";

            Posters poster3 = new Posters("Guns N’ Roses", 20, "Группа Guns N' Roses была основана в марте 1985 года Роузом и ритм-гитаристом Стрэдлином, наряду с ведущим гитаристом Трэйси Ганзом, басистом Оле Байхом и ударником Робом Гарднером из L.A. Guns.");
            Name3.Text = poster3.productName;
            Price3.Text = poster3.productPrice.ToString() + " руб.";

            Posters poster4 = new Posters("Nirvana", 20, "Американская рок-группа, созданная вокалистом и гитаристом Куртом Кобейном и басистом Кристом Новоселичем в Абердине, штат Вашингтон, в 1987 году.");
            Name4.Text = poster4.productName;
            Price4.Text = poster4.productPrice.ToString() + " руб.";

            Posters poster5 = new Posters("Marilyn Manson", 20, "Американский рок-певец, композитор, актёр, поэт-песенник, художник и бывший музыкальный журналист, основатель и бессменный лидер рок-группы Marilyn Manson.");
            Name5.Text = poster5.productName;
            Price5.Text = poster5.productPrice.ToString() + " руб.";

            Posters poster6 = new Posters("Ozzy Osbourne", 20, "Британский рок-певец, музыкант, один из основателей и участник группы Black Sabbath, оказавшей значительное влияние на появление таких музыкальных стилей, как хард-рок и хеви-метал.");
            Name6.Text = poster6.productName;
            Price6.Text = poster6.productPrice.ToString() + " руб.";

        }

        private void Image_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            Posters poster1 = new Posters("AC/DC", 20, "Австралийская рок-группа, сформированная в Сиднее в ноябре 1973 года выходцами из Шотландии, братьями Малькольмом и Ангусом Янгами.");
            Desc1.Text = poster1.shortDescription;
        }

        private void Image_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            Posters poster2 = new Posters("Arctic Monkeys", 20, "Британская рок-группа, сформированная в 2002 году в Хай Грин, пригороде Шеффилда.");
            Desc1.Text = poster2.shortDescription;
        }

        private void Image_MouseDown3(object sender, MouseButtonEventArgs e)
        {
            Posters poster3 = new Posters("Guns N’ Roses", 20, "Группа Guns N' Roses была основана в марте 1985 года Роузом и ритм-гитаристом Стрэдлином, наряду с ведущим гитаристом Трэйси Ганзом, басистом Оле Байхом и ударником Робом Гарднером из L.A. Guns.");
            Desc1.Text = poster3.shortDescription;
        }

        private void Image_MouseDown4(object sender, MouseButtonEventArgs e)
        {
            Posters poster4 = new Posters("Nirvana", 20, "Американская рок-группа, созданная вокалистом и гитаристом Куртом Кобейном и басистом Кристом Новоселичем в Абердине, штат Вашингтон, в 1987 году.");
            Desc1.Text = poster4.shortDescription;
        }

        private void Image_MouseDown5(object sender, MouseButtonEventArgs e)
        {
            Posters poster5 = new Posters("Marilyn Manson", 20, "Американский рок-певец, композитор, актёр, поэт-песенник, художник и бывший музыкальный журналист, основатель и бессменный лидер рок-группы Marilyn Manson.");
            Desc1.Text = poster5.shortDescription;
        }

        private void Image_MouseDown6(object sender, MouseButtonEventArgs e)
        {
            Posters poster6 = new Posters("Ozzy Osbourne", 20, "Британский рок-певец, музыкант, один из основателей и участник группы Black Sabbath, оказавшей значительное влияние на появление таких музыкальных стилей, как хард-рок и хеви-метал.");
            Desc1.Text = poster6.shortDescription;
        }


    }
}
