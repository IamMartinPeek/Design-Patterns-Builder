using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class CarBuilder
    {
        protected Car _Car;

        public Car NewCar
        {
            get { return _Car; }
        }

        public CarBuilder(Car car)
        {
            _Car = car;
        }

        public abstract void AddHorsePower();
        public abstract void AddTire();
        public abstract void AddRims();
        public abstract void AddColor();
    }
}
