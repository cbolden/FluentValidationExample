using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;

namespace FluentValidationExample
    {
    public class Customer
        {

        public Int32 AccountNumber { get; set; }
        public int AccessCode { get; set; }
        public string EmailAddress { get; set; }

         }
    }
