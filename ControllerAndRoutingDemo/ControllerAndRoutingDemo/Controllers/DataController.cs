using ControllerAndRoutingDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerAndRoutingDemo.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*public IActionResult MyAction(Data model)
        {
            if (model.ConvertToLower)
            {
                model.data = model.data.ToLower();
            }
            
           

            return View(model);
        }*/
       /* public IActionResult DataOperations(string data, bool convertToLower, bool countLength)
        {
            if (convertToLower)
            {
                data = data.ToLower();
            }

            
            int length = 0;
            if (countLength)
            {
                length = data.Length;
            }
            return Content();*/
            //return View();

        }
    }

