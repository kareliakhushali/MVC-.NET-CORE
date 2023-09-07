using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models
{
   public  interface IProduct
    {
        public Product GetProductById(int id);
        public IEnumerable<Product> GetAllProduct();
        public bool AddProduct(Product e);
        public bool UpdateProduct(Product e);
        public bool Delete(int id);

    }
}
