using System.Data.Entity.Migrations;

namespace RedesApp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<RedesApp.DBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RedesApp.DBcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
