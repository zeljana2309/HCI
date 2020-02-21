using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp2.Validacija
{
    class ValidationString : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string vrijednost = Convert.ToString(value);

            try
            {
                if (!(String.IsNullOrEmpty(vrijednost)))
                {
                    return new ValidationResult(true, "");
                }
                return new ValidationResult(false, "Polje ne smije biti prazno.");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }

            
        }
    }
}
