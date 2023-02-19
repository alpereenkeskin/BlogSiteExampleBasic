using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.DataAccess.Abstract
{
    public interface IMessage2Repository:IEntityRepository<Message2>
    {
        List<Message2> GetListMessageByWriter(int id);

    }
}
