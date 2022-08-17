using System;


namespace ClassCars
{
    class PassCar : Cars
    {
        int Passenger = 0;
        int PassengerLimit;

        public PassCar(string type, int fullVolumeTank, int speed, double averageFuelConsumption, int currentVolume, int passenger,int passengerLimit) : base(type, fullVolumeTank, speed, averageFuelConsumption, currentVolume)
        {
            Passenger = passenger;
            PassengerLimit = passengerLimit;
            if(Passenger > PassengerLimit)
            {
                throw new ArgumentException("Машина не поедет! Перегрузка!");
            }
        }

        public override double Dashboard()
        {
            return (CurrentVolume / AverageFuelConsumption) * Consumption * (1 - Passenger * 0.06);
        }







    }
}
