using Domain.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Domain.Services.ProductMemoryStore
{
    public class ProductMemoryStoreService : IProductMemoryStoreService
    {
        private const string _cacheKey = "Products";

        HttpContext _Context;
        private HttpContext Context
        {
            get
            {
                if (_Context == null)
                {
                    _Context = HttpContext.Current;
                }
                return _Context;
            }
        }
        public List<ProductContract> GetAll()
        {
            List<ProductContract> products = new List<ProductContract>();

            if (Context.Cache[_cacheKey] != null)
            {
                products = JsonConvert.DeserializeObject<List<ProductContract>>(Context.Cache["Products"].ToString());
            }

            return products;
        }

        public bool AddProduct(ProductContract product)
        {
            List<ProductContract> products = GetAll();
            products.Add(product);
            string json = JsonConvert.SerializeObject(products);

            if (Context.Cache[_cacheKey] != null)
            {
                Context.Cache.Remove(_cacheKey);
            }

            var cTime = DateTime.Now.AddSeconds(Convert.ToInt32(ConfigurationManager.AppSettings["SegCache"]));
            var cExp = System.Web.Caching.Cache.NoSlidingExpiration;
            var cPri = System.Web.Caching.CacheItemPriority.Normal;
            Context.Cache.Add(_cacheKey, json, null, cTime, cExp, cPri, null);
            return true;
        }
    }
}
