using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.Presentation.Areas.Admin.Models;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BlogSiteExample.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())//Bir Excel Dosyası Oluşturuyoruz.
            {
                var worksheet = workbook.Worksheets.Add("BlogListesi");//excel dosyasına isim veriyoruz.
                worksheet.Cell(1, 1).Value = "BlogID";
                worksheet.Cell(1, 2).Value = "BlogName";
                int BlogRowCount = 2;
                foreach (var item in GetList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.Id;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "users.xlsx");
                }
            }
        }
        public List<BlogModel> GetList()
        {
            List<BlogModel> blogModels = new List<BlogModel>()
            {
                new BlogModel{Id=1,BlogName="Deneme1"},
                new BlogModel{Id=2,BlogName="Deneme2"},
                new BlogModel{Id=3,BlogName="Deneme3"}
            };
            return blogModels;
        }
        public IActionResult GetBlogListExcel()
        {
            return View();
        }



        public IActionResult GetBlogTitleList()
        {
            return View();
        }
        public IActionResult ExportDynamicListExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Name ";

                int rowcount = 2;
                foreach (var item in blogTitleList())
                {
                    worksheet.Cell(rowcount,1).Value = item.Id;
                    worksheet.Cell(rowcount,2).Value = item.BlogName;
                    rowcount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "users.xlsx");
                }
            }
        }
        public List<BlogModel2> blogTitleList()
        {
            List<BlogModel2> blogModels = new List<BlogModel2>();
            using (var c = new ApplicationContext())
            {
                blogModels = c.Blogs.Select(x => new BlogModel2
                {
                    Id = x.BlogId,
                    BlogName = x.BlogTitle
                }).ToList();
            }
            return blogModels;
        }
    }
}
