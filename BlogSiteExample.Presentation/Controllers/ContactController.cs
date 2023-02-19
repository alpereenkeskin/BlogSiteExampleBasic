using Microsoft.AspNetCore.Mvc;

namespace BlogSiteExample.Presentation.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
