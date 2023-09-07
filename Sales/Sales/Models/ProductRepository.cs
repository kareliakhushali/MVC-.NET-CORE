using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class ProductRepository:IProduct
    {
        private List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product{Id=1,Name="Lux",Qty=10,Rate=38,Profile="default.jpg",IsActive=true,CatId=1},
                new Product{Id=2,Name="Dove",Qty=10,Rate=50,Profile="default.jpg",IsActive=true,CatId=1},
                new Product{Id=3,Name="Nyle",Qty=15,Rate=198,Profile="default.jpg",IsActive=true,CatId=2},
                new Product{Id=4,Name="Sunsilk",Qty=25,Rate=165,Profile="default.jpg",IsActive=true,CatId=2},

            };
        }
            public bool AddProduct(Product p)
            {
                int index = _products.FindIndex(each => each.Name.ToLower() == p.Name.ToLower());
                if(index == -1)
                {
                    p.Id = _products.Max(each => each.Id) + 1;
                    _products.Add(p);
                    return true;
                }
                return false;
            }
            public bool Delete(int id)
            {
            Product p = _products.FirstOrDefault(each => each.Id == id);

            if(p!=null)
            {
                _products.Remove(p);
                return true;
            }
            return false;
            }
        public IEnumerable<Product>GetAllProduct()
        {
            return _products;
        }
        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(each => each.Id == id);
        }
        public bool UpdateProduct(Product p)
        {
            int count = _products.Count(each => each.Name.ToLower() ==
            p.Name.ToLower() && each.Id != p.Id);
            if(count == 0)
            {
                Product updateProduct = _products.FirstOrDefault(each => each.Id == p.Id);
                updateProduct.CatId = p.CatId;
                updateProduct.Rate = p.Rate;
                updateProduct.Name = p.Name;
                updateProduct.IsActive = p.IsActive;
                updateProduct.Profile = p.Profile;
                return true;
            }
            return false;
        }
        }
    }

