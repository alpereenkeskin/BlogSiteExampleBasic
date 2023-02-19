using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using BlogSiteExample.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogSiteExample.Presentation.Controllers
{
    [Authorize]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepo());
        public IActionResult Index()
        {
            var username = User.Identity.Name;
            ApplicationContext c = new ApplicationContext();
            var writername = c.Writers.Where(x => x.WriterMail == username).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v = writername;
            return View();
        }  
        public IActionResult BlogList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditProfile(int id)
        {
            var writername = User.Identity.Name;
            ApplicationContext context = new ApplicationContext();
            var writerid = context.Writers.Where(x=>x.WriterMail==writername).Select(y=>y.WriterId).FirstOrDefault();
            return View(writerManager.GetValue(writerid));
        }
        [HttpPost]
        public IActionResult EditProfile(Writer writer)
        {
            if (ModelState.IsValid)
            {
                writer.GenderId = 1; 
                writerManager.Update(writer);
                return RedirectToAction("Index", "Writer");
            }
            return View();
        }
    }
}
