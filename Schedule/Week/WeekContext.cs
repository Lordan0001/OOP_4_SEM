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

        public DbSet<Tuesday> Tuesdays { get; set; }
        public DbSet<Wednesday> Wednesdays { get; set; }
        public DbSet<Thursday> Thursdays { get; set; }
        public DbSet<Friday> Fridays { get; set; }
        public DbSet<Saturday> Saturdays { get; set; }

    }
}
