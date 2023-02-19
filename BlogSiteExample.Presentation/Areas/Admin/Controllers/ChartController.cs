using BlogSiteExample.Presentation.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogSiteExample.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryList()
        {
            List<CategoryClass> categories = new List<CategoryClass>();
            categories.Add(new CategoryClass { CategoryName = "Yazılım", CategoryCount = 43 });
            categories.Add(new CategoryClass { CategoryName = "Model", CategoryCount = 32 });
            categories.Add(new CategoryClass { CategoryName = "Deri", CategoryCount = 768 });
            categories.Add(new CategoryClass { CategoryName = "Tekstil", CategoryCount = 12 });
            return Json(new { jsonlist = categories });
        }
    }
}
