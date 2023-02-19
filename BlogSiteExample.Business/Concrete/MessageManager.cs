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
    public class MessageManager : IMessageService
    {
        IMessageRepository _repository;
        public MessageManager(IMessageRepository repository)
        {
            _repository = repository;
        }
        public void Add(Message entity)
        {
            _repository.Create(entity);
        }

        public void Delete(Message entity)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAll()
        {
            return _repository.GetAll();    
        }

        public Message GetValue(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
