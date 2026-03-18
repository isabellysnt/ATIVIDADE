using System;
using AT1;

class Program
{
    static void Main(string[] args)
    {
        
        ISensorTemperatura sensorF = new SensorFahrenheit(77);
        Console.WriteLine("Fahrenheit: " + sensorF.LerTemperaturaCelsius());

        SensorKelvin sensorK = new SensorKelvin(300);
        ISensorTemperatura sensorAdaptado = new SensorKelvinAdapter(sensorK);

        Console.WriteLine("Kelvin: " + sensorAdaptado.LerTemperaturaCelsius());
    }
}