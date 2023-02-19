using BlogSiteExample.Entity.Entities;
using BlogSiteExample.Business.Abstract;
using BlogSiteExample.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BlogSiteExample.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogRepository _blogrepo;
        public BlogManager(IBlogRepository blogrepo)
        {
            _blogrepo = blogrepo;
        }
        public void Add(Blog entity)
        {
            _blogrepo.Create(entity);
        }

        public List<Blog> BlogListWithWriter(int? id)
        {
            return _blogrepo.BlogListWithWriter(id);
        }

        public int BlogListWithWriterId(int? id)
        {
            return _blogrepo.BlogListByWriterId(id);
        }

        public void Delete(Blog entity)
        {
            _blogrepo.Delete(entity);
        }

        public List<Blog> GetAll()
        {
            return _blogrepo.GetAll();
        }

        public Blog GetMostViewBlog()
        {
            return _blogrepo.GetMostViewsBlog(); 
        }

        public Blog GetValue(int id)
        {
            return _blogrepo.GetById(id);
        }

        public void Update(Blog entity)
        {
            _blogrepo.Update(entity);

        }
    }
}
