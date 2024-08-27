namespace StaticExercise1;

public class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        var result = (fahrenheit - 32) * 5/9;

        return result;
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        var result = (celsius * 9) / 5 + 32;
        return result;
    }
}