using System;

namespace ClassCars
{
    abstract class Cars
    {
        public const int Consumption = 100;
        public int FullVolumeTank { get; set; }
        public double Speed{ get; set; }
        
        public int CurrentVolume { get; set; }
        public double AverageFuelConsumption { get; set; }
        public double Distance { get; set; }
        public string Type { get; set; }
        public Cars(string type,int fullVolumeTank, int speed , double averageFuelConsumption,int currentVolume)
        {
            Type=type;
            FullVolumeTank = fullVolumeTank;
            Speed = speed;
            AverageFuelConsumption = averageFuelConsumption;
            CurrentVolume = currentVolume;
        }
        public double DistanceCalcFull()
        {
            return  DistanceCalc(FullVolumeTank); 
        }
        public  double DistanceCalcCurrent()
        {
            return DistanceCalc(CurrentVolume);
        }
        public double DistanceCalc(int Fuel)
        {
            return Fuel / AverageFuelConsumption;
        }
        public  virtual double Dashboard()
        {
            return (CurrentVolume / AverageFuelConsumption) * Consumption;
        }
        public double TravelTime(double Distance)
        {
            var buf = (CurrentVolume / AverageFuelConsumption) * Speed;//столько сможет проехать 
            if (Distance > buf)
            {
                throw new ArgumentException("Машина не проедет это расстояние, топливо кончится раньше!");
            }
            else
            {
                return Distance / Speed;
            }
        }

    }
}
