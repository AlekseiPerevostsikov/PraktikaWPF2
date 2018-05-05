using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_wpf2_Perevostsikov
{
    public class Context : DbContext
    {
        public Context(string connectionName)
            : base(connectionName)
        {
        }

        public Context()
            : base("CampConnection")
        {
        }


        public DbSet<Camp> Camps { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
