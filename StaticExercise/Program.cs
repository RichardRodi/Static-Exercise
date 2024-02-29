namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = TempConverter.FahrenheitToCelsius(44.3);
            Console.WriteLine($"44.3 Degrees Fahrenheit is {answer} Celsius\n");


            var answer2 = TempConverter.CelsiusToFarenheit(56.8);
            Console.WriteLine($"56.8 degrees Celsius is {answer2} Fahrenheit"); 

        }

    }           
}

