using Autofac;
using Infraestructure.Model.Model;
using Infraestructure.Repository.Mapper;
using Infraestructure.Repository.Repositories;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Infraestructure.Repository.Config
{
    public class AutofacConfig
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<Entities>().As<Entities>().Named("entities", typeof(Entities)).InstancePerRequest();
            builder.RegisterType<MapperClient>().As<IMapperDependency>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerRequest();
        }
    }
}
