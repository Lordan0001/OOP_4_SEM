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

        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<StudentTicket> StudentsTickets { get; set; }

    }
}
