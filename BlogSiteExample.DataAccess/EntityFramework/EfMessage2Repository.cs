using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.Repositories;
using BlogSiteExample.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.DataAccess.EntityFramework
{
    public class EfMessage2Repository : EntityRepository<Message2>, IMessage2Repository
    {
        public List<Message2> GetListMessageByWriter(int id)
        {
            using (var c = new ApplicationContext())
            {
                return c.Message2s.Include(x => x.SenderUserID).Include(x=>x.RecieverID).Where(x => x.Sender == id).ToList();
            }
        }
    }
}
