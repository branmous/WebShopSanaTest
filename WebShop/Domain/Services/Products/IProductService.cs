using Domain.Contracts;
using System.Collections.Generic;

namespace Domain.Services.Products
{
    public interface IProductService
    {
        bool CreateProduct(ProductContract request);
        List<ProductContract> GetAll();
    }
}