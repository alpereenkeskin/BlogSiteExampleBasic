using BlogSiteExample.Entity.Entities;
using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using BlogSiteExample.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogSiteExample.DataAccess.EntityFramework
{
    public class EfBlogRepo : EntityRepository<Blog>, IBlogRepository
    {
        public int BlogListByWriterId(int? id)
        {
            using (var c = new ApplicationContext())
            {
                return c.Blogs.Where(x => x.WriterId == id).Count();
            }
        }

        public List<Blog> BlogListWithWriter(int? id)
        {
            using (var c = new ApplicationContext())
            {
                return c.Blogs.Include(x=>x.Category).Include(y=>y.Writer).Where(x=>x.WriterId==id).ToList();
            }
        }

        public Blog GetMostViewsBlog()
        {
            using (var c = new ApplicationContext())
            {
                return c.Blogs.OrderByDescending(x=>x.Views).First();
            }
        }
    }
}
