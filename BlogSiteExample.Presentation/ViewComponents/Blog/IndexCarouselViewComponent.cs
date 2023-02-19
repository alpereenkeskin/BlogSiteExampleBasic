using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteExample.Presentation.ViewComponents.Blog
{
    public class IndexCarouselViewComponent:ViewComponent
    {
        BlogManager _blogmana = new BlogManager(new EfBlogRepo());
        public IViewComponentResult Invoke()
        {

            return View(_blogmana.GetMostViewBlog());
        }
    }
}
