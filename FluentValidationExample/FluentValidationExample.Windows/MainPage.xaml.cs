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

        private void Submit_Click(object sender, RoutedEventArgs e)
            {

            }
        }


    public class Customer : AbstractValidator<Customer>
        {

        public Int32 AccountNumber { get; set; }
        public int AccessCode { get; set; }
        public string EmailAddress { get; set; }


        }


    public class CustomerValidator : AbstractValidator<Customer>
        {
        // instantiate the Customer class
        public Customer customer = new Customer( );

        // place validation rules within CustomerValidator constructor
        public CustomerValidator( )

            // validation rules
            {
            RuleFor(customer => customer.AccountNumber).NotEmpty( );
            RuleFor(customer => customer.AccessCode).NotEmpty( );
            RuleFor(customer => customer.EmailAddress).EmailAddress( );

            }

        }

    }
