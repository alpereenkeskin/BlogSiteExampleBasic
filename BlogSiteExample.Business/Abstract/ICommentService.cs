using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.Abstract
{
    public interface ICommentService:IEntityService<Comment>
    {
        List<Comment> CommentListByBlog(int id);
    }
}
