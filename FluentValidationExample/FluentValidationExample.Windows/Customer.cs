using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace FluentValidationExample
    {
    //the main class being validated
  public class Customer
        {
        public int AccountNum { get; set; }
        public int AccessCode { get; set; }
        public string Email { get; set; }
        public string EmailConfirm { get; set; }
        }
      

    }
