using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_13
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("MyConnection1")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ByProduct> ByProducts { get; set; }


    }
}
