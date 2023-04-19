using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }


        public static double FahrenheitToCelsius(double fahrenheit)
        {

            var result = fahrenheit - 32 / 1.8;

            return result;

        }

        public static double CelsiusToFahrenheit(double celsius)

        {

            var result = celsius * 1.8 + 32;

            return result;

        }




    }
}

