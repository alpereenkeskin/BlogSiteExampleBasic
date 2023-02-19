using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using BlogSiteExample.Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogSiteExample.Presentation.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepo());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.BlogId = 5;
            p.CommentDate = DateTime.Now;
            commentManager.Add(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
