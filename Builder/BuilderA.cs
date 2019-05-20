using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuilderA : CarBuilder
    {
        public BuilderA(Car car) : base(car)
        {
        }

        public override void AddColor()
        {
            _Car.Color = "Green";
        }

        public override void AddHorsePower()
        {
            _Car.HorsePower += 35;
        }

        public override void AddRims()
        {
            _Car.Rims = "21 inch";
        }

        public override void AddTire()
        {
            _Car.Tire = "Continental Premimum Contact 6 245 / 40 R21 100Y XL";
        }
    }
}
