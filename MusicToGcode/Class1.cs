using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicToGcode
{
    internal class FrequencyToSpeed
    {
        private double _Frequency, _PrinterSpeed;

        public FrequencyToSpeed(double frequency, double printerSpeed)
        {
            _Frequency = frequency;
            _PrinterSpeed = printerSpeed;
        }

        public double Frequency
        {
            get { return _Frequency; }
            set { _Frequency = value; }
        }

        public double PrinterSpeed
        {
            get { return _PrinterSpeed; }
            set { _PrinterSpeed = value; }
        }
    }
}
