using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace BlogSiteExample.Presentation.Areas.Admin.ViewComponents.Statistic1
{
    public class Statistic1ViewComponent:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepo());
        ApplicationContext context = new ApplicationContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.blogs = blogManager.GetAll().Count();
            ViewBag.messages = context.Message2s.Count();
            ViewBag.comments = context.Contacts.Count();
            string apikey = "ef8213db72b3a86bd293ff17b4f1323e";
            string apiurl = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid="+apikey;
            XDocument document = XDocument.Load(apiurl);
            ViewBag.weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }

    }
}
