using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sales.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    
    
    public class Administration : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        public Administration(RoleManager<IdentityRole>roleManager,UserManager<IdentityUser>userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model)
        {
          if(ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(role);
                if(result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                else
                {
                    foreach (var each in result.Errors)
                        ModelState.AddModelError("", each.Description);
                }
            }
            return View(model);
        }
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel models)
        {
            var role = roleManager.Roles.FirstOrDefault(each => each.Id == models.RoleId);
            role.Name = models.RoleName;
            var result = await roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("ListRoles");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(models);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
