using BlogSiteExample.Presentation.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace BlogSiteExample.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AjaxWriterList()
        {
            var list = JsonConvert.SerializeObject(writers);
            return Json(list);
        }
        public IActionResult ajaxgetWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.id == id);
            var jsonwriter = JsonConvert.SerializeObject(writer);
            return Json(jsonwriter);
        }
        public List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass{id=1,Name="Alperen"},
            new WriterClass{id=2,Name="Dilem"},
            new WriterClass{id=3,Name="Duygu"},
            new WriterClass{id=4,Name="İrem"},
        };
    }
}
