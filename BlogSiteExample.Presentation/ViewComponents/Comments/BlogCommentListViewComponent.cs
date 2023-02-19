using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteExample.Presentation.ViewComponents.Comments
{
    public class BlogCommentListViewComponent:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepo());
        public IViewComponentResult Invoke(int id)
        {
            return View(commentManager.CommentListByBlog(id));
        }
    }
}
