using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
   public abstract class Status
    {
        public abstract string ShowStatus();
    }
    public abstract class Wanna
    {
        public abstract string ShowWanna();
    }

    public class StStatus : Status
    {
        public override string ShowStatus()
        {
            //Console.WriteLine("Учится!");
            return "Учится!";
        }
    }
    public class EnStatus : Status
    {
        public override string ShowStatus()
        {
            //Console.WriteLine("Еще не учится!");
            return "Еще не учится!";
        }
    }
    public class StWanna : Wanna
    {
        public override string ShowWanna()
        {
            //  Console.WriteLine("Нет, уже учится");
            return "Нет, уже учится";
        }
    }
    public class EnWanna : Wanna
    {
        public override string ShowWanna()
        {
            // Console.WriteLine("Да, еще не учится");
            return "Да, еще не учится";
        }
    }
    [Serializable]
    public abstract class HumanFactory
    {
        public abstract Status createStatus();
        public abstract Wanna createWanna();
    }
    /*    class Student : HumanFactory
        {
            public override Status createStatus()
            {
                return new StStatus();
            }

            public override Wanna createWanna()
            {
                return new StWanna();
            }
        }*/

    public class Human
    {
        private Status status;
        private Wanna wanna;

        public Human(HumanFactory factory)
        {
            status = factory.createStatus();
            wanna = factory.createWanna();
        }

        public string HisStatus()
        {
            return status.ShowStatus();
        }
        public string HisWanna()
        {
            return wanna.ShowWanna();
        }

    }
}
