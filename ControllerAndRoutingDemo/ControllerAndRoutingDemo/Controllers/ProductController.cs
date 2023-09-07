using ControllerAndRoutingDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ControllerAndRoutingDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            String value = "This is index of product";
            return Content(value);
         //   return View();
        }
        public IActionResult Details(int id)
        {
            return Content($"<h1>Details of {id} </h1>");
        }
        public IActionResult Display(int id)
        {
            String value = $"<h1>Details of {id} </h1>";
            return View("Display", value);
        }
        public IActionResult Opr(int no1,int no2)
        {
            String ans = $"{no1}\n+\n{no2}\n=\n{ControllerAndRoutingDemo.Models.Opr.Add(no1 ,no2)}";
            return Content(ans);
        }
        public IActionResult GetAllProduct()
        {
            String output = String.Empty;
            output = $"{"Id",-10}{"Name",-20}{"Qty",-10}{"Rate",-10}\n";
            for (int loop = 1; loop < 50; loop++) output += "-";
            output += "\n";
            foreach (Product p in GetProducts())
            {
                output += $"{p.Id,-10}{p.Name,-20}{p.Qty,-10}{p.Rate,-10}\n";
            }
            return Content(output);
        }
        public IActionResult GetProductById(int id)
        {
            String output = String.Empty;
           
           
            
               if(id<=0)
                {
                    output = $"Invalid ID";
                    return Content(output);
                }
                List<Product> products = GetProducts();
                int index = products.FindIndex(each => each.Id == id);
                if(index == -1)
                {
                    return Content($"{id} doesnot exists");
                }
                Product p = products[index];
                output = $"{p.Id,-10}{p.Name,-20}{p.Qty,-10}{p.Rate,-10}\n";
                return Content(output);
               
            }
        private List<Product> GetProducts()
        {

            List<Product> products = new List<Product>()
        {
            new Product(){Id=1,Name="Prod1",Qty=100,Rate=85},
            new Product(){Id=2,Name="Prod2",Qty=120,Rate=50},
            new Product(){Id=1,Name="Prod3",Qty=45,Rate=105},
            new Product(){Id=1,Name="Prod4",Qty=10,Rate=190},
        };
            return products;

        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Save(int Id,String Name,int Qty,int Rate)
        {
            Product p = new Product()
            {
                Id = Id,
                Name = Name,
                Qty = Qty,
                Rate = Rate

            };
            return View("Show", p);
        }
        public IActionResult SaveHelper(IFormCollection form)
        {
            int id = Convert.ToInt32(form["Id"]);
            String name = form["Name"];
            int.TryParse(form["Qty"], out int qty);
            int.TryParse(form["Rate"], out int rate);
            Product p = new Product()

            {
                Id = id,
                Name = name,
                Qty = qty,
                Rate = rate
            };
            return View("Show", p);
        }
        [HttpPost]
        public IActionResult SaveHelperRequest()
        {
            int id = Convert.ToInt32(Request.Form["Id"]);
            String name = Request.Form["Name"];
            int.TryParse(Request.Form["Qty"], out int qty);
            int.TryParse(Request.Form["Rate"], out int rate);
            Product p = new Product()

            {
                Id = id,
                Name = name,
                Qty = qty,
                Rate = rate
            };
            return View("Show", p);
        }

        public IActionResult AddHelper()
        {
            return View();
        }
        /* return Content(output);*/
    }
        
}
