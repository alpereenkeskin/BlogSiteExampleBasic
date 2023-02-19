using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using BlogSiteExample.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteExample.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            BlogManager blogmanager = new BlogManager(new EfBlogRepo());
            return View(blogmanager.GetAll());
        }
        public IActionResult About()
        {
            return View();

        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact p)
        {
            ContactManager contactManager = new ContactManager(new EfContactRepo());
            contactManager.Add(p);
            return View();
        }

    }
}
