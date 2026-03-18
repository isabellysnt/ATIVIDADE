using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1
{
    public class SensorKelvinAdapter : ISensorTemperatura
    {
        private SensorKelvin sensorKelvin;

        public SensorKelvinAdapter(SensorKelvin sensor)
        {
            sensorKelvin = sensor;
        }

        public double LerTemperaturaCelsius()
        {
            double kelvin = sensorKelvin.LerTemperaturaKelvin();
            return kelvin - 273.15;
        }
    }
}
