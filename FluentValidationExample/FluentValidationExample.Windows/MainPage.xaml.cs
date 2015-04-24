using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using FluentValidation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FluentValidationExample
    {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
        {
        public MainPage( )
            {
            this.InitializeComponent( );
            }


        //Create a validator class



        bool validationSucceeded = results.IsValid;
        IList<ValidationFailure> failures = results.Errors;

        public class CustomerValidator : AbstractValidator<Customer>
            {
            public CustomerValidator( )
                {
                RuleFor(customer => customer.Surname).NotEmpty( );
                RuleFor(customer => customer.Forename).NotEmpty( ).WithMessage("Please specify a first name");
                RuleFor(customer => customer.Discount).NotEqual(0).When(customer => customer.HasDiscount);
                RuleFor(customer => customer.Address).Length(20, 250);
                //RuleFor(customer => customer.Postcode).Must(BeAValidPostcode).WithMessage("Please specify a valid postcode");
                }

            //private bool BeAValidPostcode(string postcode)
            //    {
            //    // custom postcode validating logic goes here
            //    }

            }

        //Create Customer class
        Customer customer = new Customer( );
        CustomerValidator validator = new CustomerValidator( );
        ValidationResult results = validator.Validate(customer);




        }



    }
