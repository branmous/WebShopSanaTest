using AutoMapper;

namespace Infraestructure.Repository.Mapper
{
    public interface IMapperDependency
    {
        IMapper GetMapper();
    }
}
