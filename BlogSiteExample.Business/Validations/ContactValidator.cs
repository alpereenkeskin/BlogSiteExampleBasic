using BlogSiteExample.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.Business.Validations
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactMail).NotEmpty();
            RuleFor(x => x.ContactMessage).NotEmpty();
            RuleFor(x => x.ContactName).NotEmpty();
        }
    }
}
