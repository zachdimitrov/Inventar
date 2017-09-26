using System.Data.Entity;
using Inventar.Models;
using Inventar.Models.Items;
using Inventar.Data.Interfaces;

namespace Inventar.Data
{
    public class InventarDbContext : DbContext, IInventarDbContext
    {
        public InventarDbContext() : base("InventarConnection")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public virtual IDbSet<Workstation> Workstations { get; set; }

        public virtual IDbSet<Monitor> Monitors { get; set; }

        public virtual IDbSet<Laptop> Laptops { get; set; }

        public virtual IDbSet<Issue> Issues { get; set; }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Tag> Tags { get; set; }

        public virtual IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
