using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace FluentValidationExample
    {
  public class Customer
        {
        public int AccountNum { get; set; }
        public int AccessCode { get; set; }
        public string Email { get; set; }
        public string EmailConfirm { get; set; }
        }
      

    }
