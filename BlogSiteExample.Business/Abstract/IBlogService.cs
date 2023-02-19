using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.Abstract
{
    public interface IBlogService:IEntityService<Blog>
    {
        Blog GetMostViewBlog();
        int BlogListWithWriterId(int? id);
        List<Blog> BlogListWithWriter(int? id);


    }
}
