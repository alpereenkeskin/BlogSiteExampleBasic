
using BlogSiteExample.Entity.Entities;
using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSiteExample.DataAccess.Concrete;

namespace BlogSiteExample.DataAccess.EntityFramework
{
    public class EfCommentRepo : EntityRepository<Comment>, ICommentRepository
    {
        public List<Comment> CommentListByBlog(int id)
        {
            using (var c = new ApplicationContext())
            {
                return c.Comments.Where(x => x.BlogId == id).ToList();
            }
        }
    }
}
