using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace FluentValidationExample
    {
    public class CustomerValidator : AbstractValidator<Customer>
        {
        public CustomerValidator( )
            {
            RuleFor(Customer => Customer.AccountNum).NotNull( ).Equal(16);
            RuleFor(Customer => Customer.AccessCode).NotNull( ).Equal(4);
            RuleFor(Customer => Customer.Email).NotNull( ).Equal(Customer => Customer.EmailConfirm);
            }
        }
    }
