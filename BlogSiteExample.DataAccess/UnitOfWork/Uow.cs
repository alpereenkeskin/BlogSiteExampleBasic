using System.Threading.Tasks;
using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.DataAccess.Concrete;
using BlogSiteExample.DataAccess.Repositories;

namespace BlogSiteExample.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly ApplicationContext _context;
        public Uow(ApplicationContext context)
        {
            _context = context;
        }
        public IEntityRepository<T> GetRepository<T>() where T : class, new()
        {
            return new EntityRepository<T>();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}