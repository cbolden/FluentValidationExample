using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;

namespace FluentValidationExample
    {
    
       public class ValidationResult
        {
        
        
        public bool IsValid { get; set; }
        public bool Errors { get; set; }
        
        }

    }