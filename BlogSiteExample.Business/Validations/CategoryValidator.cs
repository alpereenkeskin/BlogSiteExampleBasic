using BlogSiteExample.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.Validations
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori ismi boş bırakılamaz.");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori Alanı Minimum 5 Karakterli olmalıdır");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategoru açıklaması boş bırakılamaz.");
        }
    }
}
