using Infraestructure.Model.Model;
using System.Linq;

namespace Infraestructure.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Entities context;

        public ProductRepository(Entities context)
        {
            this.context = context;
        }
        public bool CreateProduct(Product product)
        {
            context.Products.Add(product);
            return context.SaveChanges() > 0;
        }

        public IQueryable<Product> GetAll()
        {
            return context.Products;
        }
    }
}
