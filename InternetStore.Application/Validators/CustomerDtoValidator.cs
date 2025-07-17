using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Application.DTOs;
using FluentValidation;

namespace InternetStore.Application.Validators
{
    public class CustomerDtoValidator : AbstractValidator<CustomerDto>
    {
        public CustomerDtoValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full name is required.")
                .Must(name => name!.Trim().Split(' ').Length >= 2)
                .WithMessage("Please provide both first name and last name.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.PhoneNumber)
                .Matches(@"^\+?\d{10,15}$")
                .When(x => !string.IsNullOrEmpty(x.PhoneNumber))
                .WithMessage("Phone number must contain 10 to 15 digits and may start with '+'.");

            RuleFor(x => x.Address)
                .NotEmpty()
                .When(x => x.Address != null)
                .WithMessage("Address cannot be an empty string.");
        }
    }
}
