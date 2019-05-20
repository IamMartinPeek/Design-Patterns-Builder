using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public static class CarAssembler
    {
        public static void Tune(CarBuilder carBuilder)
        {
            carBuilder.AddHorsePower();
            carBuilder.AddRims();
            carBuilder.AddTire();
            carBuilder.AddColor();
        }
    }
}
