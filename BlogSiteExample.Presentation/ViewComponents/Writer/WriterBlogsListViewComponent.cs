using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogSiteExample.Presentation.ViewComponents.Writer
{
    public class WriterBlogsListViewComponent:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepo());
        public IViewComponentResult Invoke()
        {
            ApplicationContext applicationContext = new ApplicationContext();
            var writername = User.Identity.Name;
            var writerid = applicationContext.Writers.Where(x => x.WriterMail == writername).Select(x=>x.WriterId).FirstOrDefault();
            return View(blogManager.BlogListWithWriter(writerid));
        }
    }
}
