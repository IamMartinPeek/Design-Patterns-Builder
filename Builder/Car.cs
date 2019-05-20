using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        string _Name;
        string _Brand;
        string _Engine;

        int _HorsePower;
        string _Tire;
        string _Rims;
        string _Color;

        public string Name { get => _Name; }
        public string Brand { get => _Brand; }
        public string Engine { get => _Engine; }

        public int HorsePower { get => _HorsePower; set => _HorsePower = value; }
        public string Tire { get => _Tire; set => _Tire = value; }
        public string Rims { get => _Rims; set => _Rims = value; }
        public string Color { get => _Color; set => _Color = value; }

        public Car(string name, string brand, string engine)
        {
            _Name = name;
            _Brand = brand;
            _Engine = engine;
            _HorsePower = 120;
            _Tire = "Continental Premimum Contact 6 195/55 R16 91V XL";
            _Rims = "15 inch";
            _Color = "Black";
        }

        public override string ToString()
        {
            return _Name + ", " + _Brand + ", " + _Engine + ", " + HorsePower + " PS, " + _Tire + ", " + _Rims + ", " + _Color;
        }
    }
}
