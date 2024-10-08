namespace OUCR.Temperatura
{
    public class TemperaturaConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9/5) + 32;
        }

        public double FahrenheitToCelsius(double fahreniet)
        {
            return (fahreniet - 32) * 5/9;
        }
    }
}
