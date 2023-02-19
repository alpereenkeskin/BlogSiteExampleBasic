using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogSiteExample.Presentation.ViewComponents.Writer
{
    public class WriterIndexBlogListViewComponent : ViewComponent
    {
        BlogManager _blogmana = new BlogManager(new EfBlogRepo());
        public  IViewComponentResult Invoke()
        {
            ApplicationContext applicationContext = new ApplicationContext();
            var writermail = User.Identity.Name;
            var writerid = applicationContext.Writers.Where(x => x.WriterMail == writermail).Select(x => x.WriterId).FirstOrDefault();
            return View(_blogmana.BlogListWithWriter(writerid));
        }
    }
}
