using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogSiteExample.Presentation.Areas.Admin.ViewComponents.Statistic2
{
    public class Statistic2ViewComponent:ViewComponent
    {
        ApplicationContext context = new ApplicationContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.lastblog = context.Blogs.OrderByDescending(x => x.BlogCreatedDate).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
