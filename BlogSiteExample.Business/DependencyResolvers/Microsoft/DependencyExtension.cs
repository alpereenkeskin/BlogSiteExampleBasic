using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(opt =>
            {
                opt.UseSqlServer("Server=localhost;Database=BlogSiteExample;Trusted_Connection=True;");
            });
            services.AddScoped<IUow,Uow>();


        }
    }
}
