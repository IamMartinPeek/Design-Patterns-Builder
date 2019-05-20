using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuilderB : CarBuilder
    {
        public BuilderB(Car car) : base(car)
        {
        }

        public override void AddColor()
        {
            _Car.Color = "Red";
        }

        public override void AddHorsePower()
        {
            _Car.HorsePower += 20;
        }

        public override void AddRims()
        {
            _Car.Rims = "19 inch";
        }

        public override void AddTire()
        {
            _Car.Tire = "Continental Premimum Contact 6 235 / 35 R19 91Y XL";
        }
    }
}
