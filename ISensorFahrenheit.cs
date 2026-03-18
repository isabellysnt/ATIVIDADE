using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1
{
    public class SensorFahrenheit : ISensorTemperatura
    {
        private double temperaturaF;

        public SensorFahrenheit(double tempF)
        {
            temperaturaF = tempF;
        }

        public double LerTemperaturaCelsius()
        {
            return (temperaturaF - 32) * 5 / 9;
        }
    }
}
