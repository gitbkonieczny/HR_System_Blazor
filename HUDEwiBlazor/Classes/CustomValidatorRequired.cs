using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor;

namespace HUDEwiBlazor.Classes
{
    public class CustomValidatorRequired: ValidationAttribute
    {
        public string AllowedDomain { get; set; }
       
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var Localizer = (ISyncfusionStringLocalizer)validationContext
                         .GetService(typeof(ISyncfusionStringLocalizer));
            string strings = value.ToString();
            if (strings == null || strings == "")
            {
                return new ValidationResult(Localizer.GetText("Required"),
                new[] { validationContext.MemberName });
            }

            return null;
            
        }
    }
}
