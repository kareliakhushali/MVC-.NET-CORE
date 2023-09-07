using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int Rate { get; set; }
        public string Profile { get; set; }
        public bool IsActive { get; set; }
        public int CatId { get; set; }

    }
}
