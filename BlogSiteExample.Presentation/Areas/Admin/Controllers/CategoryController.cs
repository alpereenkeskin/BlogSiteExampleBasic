using BlogSiteExample.Business.Concrete;
using BlogSiteExample.Business.Validations;
using BlogSiteExample.DataAccess.EntityFramework;
using BlogSiteExample.Entity.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace BlogSiteExample.Presentation.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepo());
        public IActionResult Index(int page = 1)
        {
            var values = categoryManager.GetAll().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddNewCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewCategory(Category p)
        {
            CategoryValidator validationRules = new CategoryValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                categoryManager.Add(p);
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            var value = categoryManager.GetValue(id);
            categoryManager.Delete(value);
            return RedirectToAction("Index","Category");
        }

    }
}
