using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
        public static double FahrenheitToCelcius(double ftemp)
        {
            return (ftemp - 32) * 5 / 9;
        }
        public static double CelciusToFahrenheit(double ctemp)
        {
            return (ctemp * 9) / 5 + 32;
        }
    }
}
