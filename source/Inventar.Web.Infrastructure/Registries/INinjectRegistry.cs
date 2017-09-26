using Ninject;

namespace Inventar.Web.Infrastructure.Registries
{
    public interface INinjectRegistry
    {
        void Register(IKernel kernel);
    }
}
