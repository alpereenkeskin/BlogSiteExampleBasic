using BlogSiteExample.Business.Abstract;
using BlogSiteExample.Business.Concrete;
using BlogSiteExample.DataAccess.EntityFramework;
using BlogSiteExample.Entity.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogSiteExample.Presentation.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepo());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Writer p)
        {
            var value = writerManager.GetWriter(p);
            if (value != null)
            {
                var claims = new List<Claim>
                    {
                       new Claim(ClaimTypes.Name,p.WriterMail),
                    };
                var useridenty = new ClaimsIdentity(claims, "p");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(useridenty);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();

            }
        }

    }
}
