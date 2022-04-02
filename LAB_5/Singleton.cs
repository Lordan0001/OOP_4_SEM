using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Singleton
    {
        private static Singleton instance;
        private Singleton()
        { }
        public static Color SiColor = Color.Blue;
        public static  Font SiFont = new Font("Times New Roman", 10, FontStyle.Bold);
        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

    }
}
