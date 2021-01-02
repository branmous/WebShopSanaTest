using Infraestructure.Repository.Mapper;

namespace WebShop.App_Start
{
    public class AutomapperConfig
    {
        public static void CreateMaps()
        {
            LocalConfig.Mapper = Domain.Config.AutomapperConfig.CreateMapper();
        }
    }
}