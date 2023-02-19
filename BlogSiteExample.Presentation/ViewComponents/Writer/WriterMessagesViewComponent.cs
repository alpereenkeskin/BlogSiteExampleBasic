using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteExample.Presentation.ViewComponents.Writer
{
    public class WriterMessagesViewComponent:ViewComponent
    {
        Message2Manager messageManager = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 1;
            return View(messageManager.GetMessagesByWriter(id));
        }
    }
}
