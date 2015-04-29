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

        public FluentValidation.Results.ValidationResult ValidationResults { get; set; }

        //Submitbutton event handler
        private void Submit_Button_Click(object sender, RoutedEventArgs e)
            {
            Customer customer = new Customer( );
            CustomerValidator validator = new CustomerValidator( );
            ValidationResults = validator.Validate(customer);
            validator.ValidateAndThrow(customer);

            

            }
       

       
        }

    }