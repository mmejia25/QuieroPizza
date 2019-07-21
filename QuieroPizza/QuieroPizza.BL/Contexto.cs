using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QuieroPizza.BL
{
    class Contexto : DbContext
    {
        public Contexto() : base("Server=L000SPSIT01;Database=QuieroPizzaDB;Trusted_Connection=True;")
        {

        }
    
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
