using BlogSiteExample.Entity.Entities;
using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.DataAccess.EntityFramework
{
    public class EfContactRepo:EntityRepository<Contact>,IContactRepository
    {
    }
}
