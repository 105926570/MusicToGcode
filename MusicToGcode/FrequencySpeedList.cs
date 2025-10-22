using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicToGcode
{
    internal class FrequencySpeedList
    {
        private int _index;
        private List<FrequencyToSpeed> _frequencySpeedList;

        // Constructor when you dont have a list yet
        public FrequencySpeedList()
        {
            _frequencySpeedList = new List<FrequencyToSpeed>();
        }

        // Constructor when you have a list already
        public FrequencySpeedList(List<FrequencySpeedList> frequencySpeedList)
        {
            _frequencySpeedList = new List<FrequencyToSpeed>();
        }

        public FrequencySpeedList(List<double> Frequency, List<double> Speed)
        {
            int a = Frequency.Count;
            int b = Speed.Count;
            int c = 0;
            FrequencyToSpeed fs;

            // set the bigger number out of a or be to be queal to c
            if (a > b)
            {
                c = a;
            }
            else if(b > a)
            {
                c = b;
            }
            else if(a == b)
            {
                c = a;
            }


            int index = 0;
            while (index < c)
            {
                if (Frequency[index] == null)
                {
                    fs = new FrequencyToSpeed(0, Speed[index]);
                }
                else if (Speed[index] == null)
                {
                    fs = new FrequencyToSpeed(Frequency[index], 0);
                }
                else
                {
                    fs = new FrequencyToSpeed(Frequency[index], Speed[index]);
                }
                _frequencySpeedList.Add(fs); //make this not care if its null
                index = index + 1;
            }
        }
    }
}
