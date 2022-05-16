using System.Windows;
using System.Windows.Input;

namespace SwitchingViewsMVVM
{

    public partial class EnterWindow : Window
    {
        public EnterWindow()
        {
            InitializeComponent();
        }
        public static void CloseEnter()
        {
            //закрыть текущее окно
            foreach (Window w in App.Current.Windows)
            {

                w.Close();
                break;
            }


        }



    }
}
