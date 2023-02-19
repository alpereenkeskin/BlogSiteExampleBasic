using BlogSiteExample.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.Abstract
{
    public interface IWriterService:IEntityService<Writer>
    {
        Writer GetWriter(Writer p);

    }
}
