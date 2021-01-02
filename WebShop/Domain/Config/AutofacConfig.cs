using Autofac;
using Domain.Services.ProductMemoryStore;
using Domain.Services.Products;

namespace Domain.Config
{
    public class AutofacConfig
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            Infraestructure.Repository.Config.AutofacConfig.RegisterTypes(builder);

            builder.RegisterType<ProductService>().As<IProductService>().InstancePerRequest();
            builder.RegisterType<ProductMemoryStoreService>().As<IProductMemoryStoreService>().InstancePerRequest();
        }
    }
}
