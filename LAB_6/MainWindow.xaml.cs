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
            String albumStr = labelHeaven.Text;
            string a = "11";
            MessageBox.Show(albumStr);



        }

        private void TextBlock_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.ShowHeavenSongs();
        }
    }
}
