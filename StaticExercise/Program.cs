namespace StaticExercise1
{
    public class Program
    {
       static void Main(string[] args)
       {
           var celsius = TempConverter.FahrenheitToCelsius(86);// 30
           var fahrenheit = TempConverter.CelsiusToFahrenheit(30);// 86
           
           Console.WriteLine($"celsius {celsius}");
           Console.WriteLine($"fahrenheit {fahrenheit}");
       }
    }
}
