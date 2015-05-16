using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Windows.UI.Popups;

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
    #region validation results
    public class ValidationResults : AbstractValidator<Customer>
        {
        // were there errors during validation
        public bool Errors { get; set; }
        // was the validation valid
        public bool IsValid { get; set; }
         public CustomerValidator customervalidator = new CustomerValidator();
        // collection of ValidationFailure objects containing details about any validation failures
        public ValidationResults( )

           
            {

            if (!IsValid)
                {
                foreach (var error in customervalidator)
                    {
                   
                   
                    }
                }
            //....

            }
        }

    #endregion

    }
