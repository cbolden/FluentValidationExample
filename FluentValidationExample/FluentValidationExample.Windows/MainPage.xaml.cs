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
    #region MainPage
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
        {
        public MainPage( )
            {
            this.InitializeComponent( );

            }


        #region  Submitbutton event handler
        private void Submit_Button_Click(object sender, RoutedEventArgs e)
            {

            Customer customer = new Customer( );
            CustomerValidator validator = new CustomerValidator( );
            IList<ValidationResult> results = validator.Validate(customer) ;

            }
        #endregion


        }
    #endregion

    #region Customer class members
    //the main class being validated
    public class Customer
        {
        public int AccountNum { get; set; }
        public int AccessCode { get; set; }
        public string Email { get; set; }
        public string EmailConfirm { get; set; }
        }
    #endregion

    }