using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forever.DTO;
using System.Data.Entity;
using Forever.Migrations;

namespace Forever.DAL
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {
            Database.SetInitializer<Context>(new ContextInitializer());
        }

        public DbSet<Order> Orders { get; set; }

        public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
        {
            protected override void Seed(Context context)
            {
                base.Seed(context);
            }

            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }
    }
}
