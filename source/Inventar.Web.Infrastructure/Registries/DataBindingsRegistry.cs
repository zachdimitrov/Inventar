using Inventar.Data;
using Inventar.Data.Interfaces;
using Ninject;
using Ninject.Web.Common;

namespace Inventar.Web.Infrastructure.Registries
{
    public class DataBindingsRegistry
    {
        public void Register(IKernel kernel)
        {
            kernel.Bind<IInventarDbContext>().To<InventarDbContext>().InRequestScope();
            kernel.Bind(typeof(IRepository<>)).To(typeof(EfRepository<>));
            kernel.Bind<IInventarData>().To<InventarData>();
        }
    }
}
