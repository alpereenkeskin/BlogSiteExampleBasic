using BlogSiteExample.Business.Concrete;
using BlogSiteExample.Business.Validations;
using BlogSiteExample.DataAccess.EntityFramework;
using BlogSiteExample.Entity.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace BlogSiteExample.Presentation.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _manager = new BlogManager(new EfBlogRepo());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepo());
        public IActionResult Index()
        {
            return View(_manager.GetAll());
        }
        public IActionResult BlogDetails(int id)
        {
            return View(_manager.GetValue(id));
        }
        public IActionResult UpdateBlog(int id)
        {
            List<SelectListItem> catvalues = (from x in categoryManager.GetAll()
                                              select new SelectListItem
                                              {
                                                  Text = x.CategoryName,
                                                  Value = x.CategoryId.ToString()
                                              }).ToList();
            ViewBag.categories = catvalues;
            return View(_manager.GetValue(id));
        }
        [HttpPost]
        public IActionResult UpdateBlog(Blog p)
        {
            p.WriterId = 1;
            BlogValidation validationRules = new BlogValidation();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                _manager.Update(p);
                return RedirectToAction("BlogList", "Writer");

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> catvalues = (from x in categoryManager.GetAll()
                                              select new SelectListItem
                                              {
                                                  Text = x.CategoryName,
                                                  Value = x.CategoryId.ToString()

                                              }).ToList();

            ViewBag.categories = catvalues;
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog p)
        {
            BlogValidation validationRules = new BlogValidation();
            ValidationResult validationResult = validationRules.Validate(p);
            p.WriterId = 1;
            p.Views = 0;
            if (validationResult.IsValid)
            {
                _manager.Add(p);
                return RedirectToAction("Index", "Writer");
            }
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var value = _manager.GetValue(id);
            _manager.Delete(value);
            return RedirectToAction("BlogList","Writer");
        }
    }
}
