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
    public class ContactManager : IContactService
    {
        private readonly IContactRepository _repository;

        public ContactManager(IContactRepository repository)
        {
            _repository = repository;
        }

        public void Add(Contact entity)
        {
           _repository.Create(entity);
        }

        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact GetValue(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
