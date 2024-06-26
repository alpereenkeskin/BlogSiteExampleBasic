﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Entity.Entities
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogImage { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogCreatedDate { get; set; }
        public bool BlogStatus { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Writer Writer { get; set; }
        public int WriterId { get; set; }
        public int Views { get; set; }
    }
}
