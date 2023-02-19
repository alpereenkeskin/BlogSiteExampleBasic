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
    
    public class CommentManager : ICommentService
    {    
        private ICommentRepository _commentRepository;
        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository; 
        }

        public void Add(Comment entity)
        {
            _commentRepository.Create(entity);
        }

        public List<Comment> CommentListByBlog(int id)
        {
            return _commentRepository.CommentListByBlog(id);    
        }

        public void Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            return _commentRepository.GetAll(); 
        }

        public Comment GetValue(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
