using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCars
{
    class SportCar : Cars
    {
        public SportCar(string type, int fullVolumeTank, int speed, double averageFuelConsumption, int currentVolume) : base(type, fullVolumeTank, speed, averageFuelConsumption, currentVolume)
        {
        }

        public override double Dashboard()
        {
            throw new NotImplementedException();
        }
    }
}
