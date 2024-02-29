using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double degree)

        {
            return (degree - 32) * 5 / 9;

        }
        public static double CelsiusToFarenheit(double degree)
        {
            return (degree * 9 / 5) + 32;
        }
    }
}
