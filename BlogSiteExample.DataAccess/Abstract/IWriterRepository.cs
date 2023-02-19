﻿using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.DataAccess.Abstract
{
    public interface IWriterRepository:IEntityRepository<Writer>
    {
        Writer GetWriter(Writer writer);
    }
}
