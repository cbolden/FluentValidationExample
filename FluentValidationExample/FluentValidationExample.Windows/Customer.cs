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
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public decimal Discount { get; set; }
        public string Address { get; set; }
        public int Postcode { get; set; }
        }
    }
