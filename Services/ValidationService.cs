using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Services
{
    internal static class ValidationService
    {
        public static bool IsNumber(TextBox textBox)
        {

            if (!(double.TryParse(textBox.Text,out double num)))
            {
                return false;
            }
            
            if (num <= 0)
            {
                return false;
            }
            

            return true;
        }
    }
}
