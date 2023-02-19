using System.Collections.Generic;
using System.Threading.Tasks;
using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.Abstract;

namespace BlogSiteExample.DataAccess.UnitOfWork
{
    public interface IUow
    {
        IEntityRepository<T> GetRepository<T>() where T : class, new();
        Task SaveChanges();


    }

}