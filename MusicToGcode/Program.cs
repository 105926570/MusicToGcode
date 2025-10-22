using System;

namespace MusicToGcode
{ 
    internal class Program
    {
        public string SoundFile, outputgcode;
        int desiredtimeframe, MaximumX;
        FrequencySpeedList _frequencySpeedList = new FrequencySpeedList();


        public double frequencyToDistance(double durationOfFrequencyinSeconds, double SpeedAtFrequencyinMillimetresPerSecond)
        {
            double distancetotravel = 0;
            distancetotravel = SpeedAtFrequencyinMillimetresPerSecond / durationOfFrequencyinSeconds;
            return distancetotravel;
        }

        public string DistanceToGcode(double distanceInMillimetres, double PreviousX, double SpeedAtFrequencyinMillimetresPerSecond)
        {
            string gcodecommand;

            if ((distanceInMillimetres + PreviousX) > MaximumX)
            { 
                gcodecommand = $"G1 X0 Y0 F3000 ;bring back to start\nG1 X{distanceInMillimetres} Y0 F{SpeedAtFrequencyinMillimetresPerSecond}\n";
            }
            else
            {
                gcodecommand = $"G1 X{distanceInMillimetres + PreviousX} Y0 F{SpeedAtFrequencyinMillimetresPerSecond}";
            }
                
            return gcodecommand;
        }

        public void AddLineToGcodeFile(string gcodeCommand)
        {
            outputgcode += "\n" + gcodeCommand;
        }
    }
}
