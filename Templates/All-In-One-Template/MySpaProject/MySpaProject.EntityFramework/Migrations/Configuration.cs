using System.Data.Entity.Migrations;

namespace MyCompany.MySpaProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MySpaProject.EntityFramework.MySpaProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MySpaProject";
        }

        protected override void Seed(MySpaProject.EntityFramework.MySpaProjectDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
