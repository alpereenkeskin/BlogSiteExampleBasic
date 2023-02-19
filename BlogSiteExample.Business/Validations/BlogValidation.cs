using BlogSiteExample.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.Validations
{
    public class BlogValidation : AbstractValidator<Blog>
    {
        public BlogValidation()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Title Alanı Boş Bırakılamaz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Content Alanı Boş Bırakılamaz.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog Title En az 5 karakter içermeli.");
        }

    }
}
