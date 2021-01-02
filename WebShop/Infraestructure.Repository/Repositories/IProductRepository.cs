using Infraestructure.Model.Model;
using System.Linq;

namespace Infraestructure.Repository.Repositories
{
    public interface IProductRepository
    {
        bool CreateProduct(Product product);

        IQueryable<Product> GetAll();
    }
}