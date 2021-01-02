using AutoMapper;
using Domain.Contracts;
using Infraestructure.Model.Model;
using Infraestructure.Repository.Mapper;
using Infraestructure.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Products
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;
        public ProductService(IProductRepository productRepository,
            IMapperDependency mapperDependency)
        {
            _productRepository = productRepository;
            _mapper = mapperDependency.GetMapper();
        }

        public List<ProductContract> GetAll()
        {
            IQueryable<Product> ProductsDB = _productRepository.GetAll();

            List<ProductContract> products = _mapper.Map<List<ProductContract>>(ProductsDB.ToList());

            return products;
        }

        public bool CreateProduct(ProductContract request)
        {
            Product product = _mapper.Map<Product>(request);

            return _productRepository.CreateProduct(product);
        }
    }
}
