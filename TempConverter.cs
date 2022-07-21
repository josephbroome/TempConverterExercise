using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelcius(double farenheit)
        {
            var result= (farenheit - 32) / 1.8;
            return result;
        }

        public static double CelciusToFaranehit(double celsius)
        {
            var result= (celsius * 9) / 5 + 32;
            return result;
        }
    
    
    }
}
