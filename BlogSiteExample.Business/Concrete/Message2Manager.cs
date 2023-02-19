using BlogSiteExample.Business.Abstract;
using BlogSiteExample.DataAccess.Abstract;
using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        private readonly IMessage2Repository _repository;

        public Message2Manager(IMessage2Repository repository)
        {
            _repository = repository;
        }

        public void Add(Message2 entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message2 entity)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Message2> GetMessagesByWriter(int id)
        {
            return _repository.GetListMessageByWriter(id);
        }

        public Message2 GetValue(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(Message2 entity)
        {
            throw new NotImplementedException();
        }
    }
}
