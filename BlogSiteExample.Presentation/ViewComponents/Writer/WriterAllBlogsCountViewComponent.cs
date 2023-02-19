using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteExample.Presentation.ViewComponents.Writer
{
    public class WriterAllBlogsCountViewComponent:ViewComponent
    {
        BlogManager manager = new BlogManager(new EfBlogRepo());
        public IViewComponentResult Invoke(int? id)
        {
            var values = manager.BlogListWithWriterId(id);
            ViewBag.blogs = values;
            return View();
        }
    }
}
