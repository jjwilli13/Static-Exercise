    namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            var fahrenheit = TempConverter.FahrenheitToCelsius(89);

            Console.WriteLine($"The temp after conversion is {fahrenheit} degrees in celsius");




            var celsius = TempConverter.CelsiusToFahrenheit(22);

            Console.WriteLine($"The temp after conversion is {celsius} degrees in fahrenheit");



        }

    }




}
