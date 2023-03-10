using Assignment.Data;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.ViewModels
{
    public class PersonViewModel
    {
        #region Properties 


        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool AlreadyExist { get; set; }
        public string Message { get; set; }
        public List<PersonViewModel> PersonViewModels { get; set; }

        #endregion

    }

    public class PersonValidator : AbstractValidator<PersonViewModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name is Required.")
                ;
            RuleFor(p => p.Email)
                .EmailAddress()
                .WithMessage("Invalid Email Address.");
            RuleFor(p => p.Age)
                .NotEmpty().WithMessage("Age should be greater than zero.")
                .NotNull().WithMessage("Age is Required.");
            
        }
    }

}