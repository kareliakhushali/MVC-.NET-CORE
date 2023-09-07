using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class ProductViewModel:Product
    {
        public string Category { get; set; }
        public IFormFile Image { get; set; }
    }
}
