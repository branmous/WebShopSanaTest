using Domain.Contracts;
using System.Collections.Generic;

namespace Domain.Services.ProductMemoryStore
{
    public interface IProductMemoryStoreService
    {
        bool AddProduct(ProductContract product);
        List<ProductContract> GetAll();
    }
}