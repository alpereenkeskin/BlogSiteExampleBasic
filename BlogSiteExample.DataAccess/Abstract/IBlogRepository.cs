using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.DataAccess.Abstract
{
    public interface IBlogRepository:IEntityRepository<Blog>
    {
        Blog GetMostViewsBlog();
        int BlogListByWriterId(int? id);
        List<Blog> BlogListWithWriter(int? id);
    }
}
