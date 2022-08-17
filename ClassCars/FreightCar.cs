using System;


namespace ClassCars
{
    class FreightCar : Cars
    {
        int Cargo = 0;
        int CargoLimit;

        public FreightCar(string type, int fullVolumeTank, int speed, double averageFuelConsumption, int currentVolume,int cargo,int cargoLimit) : base(type, fullVolumeTank, speed, averageFuelConsumption, currentVolume)
        {
            Cargo = cargo;
            CargoLimit = cargoLimit;
            if (Cargo > CargoLimit)
            {
                throw new ArgumentException("Машина не поедет! Перегрузка!");
            }   
        }
        public  override double Dashboard()
        {
            
            {
                return (CurrentVolume / AverageFuelConsumption) * Consumption * (1 - (Cargo / 200) * 0.04);
                
            }
            
        }

        
    }
}
