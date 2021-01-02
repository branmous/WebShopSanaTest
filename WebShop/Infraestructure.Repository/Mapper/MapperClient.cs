namespace Infraestructure.Repository.Mapper
{
    public class MapperClient : IMapperDependency
    {
        public MapperClient()
        {
        }

        public AutoMapper.IMapper GetMapper()
        {
            return LocalConfig.Mapper;
        }
    }
}
