using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Product Name should not be empty")]
        [MaxLength(100,ErrorMessage ="Product Name should not be more than 100 characters")]
        public string Name { get; set; }

        [Range(1,Int32.MaxValue,ErrorMessage ="Qty should not be more than 0")]
        public int Qty { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Rate should be more than 0")]

        public int Rate { get; set; }
        public string Profile { get; set; }
        public bool IsActive { get; set; } = true;
        public int CatId { get; set; }

    }
}
