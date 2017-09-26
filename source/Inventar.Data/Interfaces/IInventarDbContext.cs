using Inventar.Models;
using Inventar.Models.Items;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Inventar.Data.Interfaces
{
    public interface IInventarDbContext
    {
        IDbSet<Workstation> Workstations { get; set; }

        IDbSet<Monitor> Monitors { get; set; }

        IDbSet<Laptop> Laptops { get; set; }

        IDbSet<Issue> Issues { get; set; }

        IDbSet<User> Users { get; set; }

        IDbSet<Tag> Tags { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
