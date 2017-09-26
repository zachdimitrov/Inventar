using System.Data.Entity.Migrations;

namespace Inventar.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<InventarDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Inventar.Data.InventarDbContext";
        }

        protected override void Seed(InventarDbContext context)
        {

        }
    }
}
