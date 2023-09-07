using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sales.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProduct _productRepository;
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;

        public HomeController(IProduct productRepository,
           IWebHostEnvironment hostingEnvironment,
          ICategory categoryRepository)
        {
            _productRepository = productRepository;
            _hostingEnvironment = hostingEnvironment;
            _categoryRepository = categoryRepository;

        }
       /* public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            ViewData["PageTitle"] = "Product List";
            var result =
               from p in _productRepository.GetAllProduct()
               join c in _categoryRepository.GetAllCategory()
               on p.CatId equals c.Id
               select new
               {
                   p.Id,
                   p.Name,
                   p.Profile,
                   p.Qty,
                   p.Rate,
                   p.IsActive,
                   p.CatId,
                   Category = c.Name
               };
            List<ProductViewModel> products = new List<ProductViewModel>();
           foreach(var each in result)
            {
                products.Add(new ProductViewModel()
                {
                    Category = each.Category,
                    CatId = each.CatId,
                    Name = each.Name,
                    Id = each.Id,
                    Profile = each.Profile,
                    IsActive = each.IsActive,
                    Rate = each.Rate,
                    Qty = each.Qty,
                }) ;
            }
            return View(products);
        }
        public IActionResult AddProduct()
        {
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View(new ProductViewModel());
        }
        public IActionResult Save(ProductViewModel p)
        {
            String uniqueFileName = string.Empty;
            if(p.Image != null)
            {
                String uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + p.Image.FileName;
                String uploadFilePath = Path.Combine(uploadFolder, uniqueFileName);
                p.Image.CopyTo(new FileStream(uploadFilePath, FileMode.Create));
                p.Profile = uniqueFileName;
            }
            if(p.Id > 0)
            {
                if(!_productRepository.UpdateProduct(p))
                {
                    ViewBag.Category = _categoryRepository.GetAllCategory();
                    return View("Add Product", p);
                }
            }
            else
            {
                if(!_productRepository.AddProduct(p))
                {
                    ViewBag.Category = _categoryRepository.GetAllCategory();
                    return View("AddProduct", p);
                };
            }
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
