using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchingViewsMVVM.Week
{
    public class WeekContext : DbContext
    {

        public WeekContext() : base("MyConnection1")
        {

        }

        public DbSet<Monday> Mondays { get; set; }


    }
}
