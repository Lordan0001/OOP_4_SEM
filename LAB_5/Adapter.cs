using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
   public class Adapter : Enrollee
    {
        private Adaptee adaptee = new Adaptee();
        public override string SetIm()
        {
            return adaptee.SpecificSetWhoim();
        }
    }


    public class Adaptee
    {
        public string SpecificSetWhoim()
        {
            return "Специальный абитуриент";
        }
    }
}
