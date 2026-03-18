using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1
{
    public class SensorKelvin
    {
        private double temperaturaK;

        public SensorKelvin(double tempK)
        {
            temperaturaK = tempK;
        }

        public double LerTemperaturaKelvin()
        {
            return temperaturaK;
        }
    }
}
