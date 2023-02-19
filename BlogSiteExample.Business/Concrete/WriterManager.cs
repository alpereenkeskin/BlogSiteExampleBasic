using BlogSiteExample.Business.Abstract;
using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.Concrete
{
    
    
    public class WriterManager : IWriterService
    {
        private IWriterRepository _writerRepository;

        public WriterManager(IWriterRepository writerRepository)
        {
            _writerRepository = writerRepository;
        }

        public void Add(Writer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Writer entity)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Writer GetValue(int id)
        {
            return _writerRepository.GetById(id);
        }

        public Writer GetWriter(Writer p)
        {
            return _writerRepository.GetWriter(p);
        }

        public void Update(Writer entity)
        {
            _writerRepository.Update(entity);
        }
    }
}
