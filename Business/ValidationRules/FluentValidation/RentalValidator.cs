using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotEmpty().When(r => r.CustomerId >= 1); 
            RuleFor(r => r.RentDate).LessThanOrEqualTo(DateTime.Now).When(r => r.CustomerId >= 1);
            RuleFor(r => r.ReturnDate).NotEmpty().When(r => r.CustomerId >= 1);
            RuleFor(r => r.ReturnDate).GreaterThan(DateTime.Now).When(r => r.CustomerId >= 1); 
        }
    }
}
