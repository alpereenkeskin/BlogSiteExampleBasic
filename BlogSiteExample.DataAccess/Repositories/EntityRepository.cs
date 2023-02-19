using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.DataAccess.Repositories
{
    public class EntityRepository<T> : IEntityRepository<T> where T : class
    {
        public void Create(T entity)
        {
            using (var c = new ApplicationContext())
            {
                c.Add(entity);
                c.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var c = new ApplicationContext())
            {
                c.Remove(entity);
                c.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var c = new ApplicationContext())
            {
                return c.Set<T>().ToList();
            }

        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            using (var c = new ApplicationContext())
            {
                return c.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var c = new ApplicationContext())
            {
                return c.Set<T>().Find(id);
            }

        }

        public void Update(T entity)
        {
            using (var c = new ApplicationContext())
            {
                c.Update(entity);
                c.SaveChanges();
            }
        }
    }
}
