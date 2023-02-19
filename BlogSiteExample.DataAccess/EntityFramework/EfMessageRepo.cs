using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.Repositories;
using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.DataAccess.EntityFramework
{
    public class EfMessageRepo : EntityRepository<Message>, IMessageRepository
    {
    }
}
