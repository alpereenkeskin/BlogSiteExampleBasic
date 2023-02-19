using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Entity.Entities
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string WriterImage { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterNickName { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public List<Blog> Blogs { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public ICollection<Message2> SenderMessages { get; set; }
        public ICollection<Message2> RecieverMessager { get; set; }

    }
}
