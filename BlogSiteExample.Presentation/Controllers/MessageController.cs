using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteExample.Presentation.Controllers
{
    public class MessageController : Controller
    {

        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SeeAllMessagesByWriter()
        {
            int id = 1;
            return View(message2Manager.GetMessagesByWriter(id));
        }
        public IActionResult MessageDetails(int id)
        {
            return View(message2Manager.GetValue(id));
        }
    }
}
