using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You want to tune your car at (1)BuilderA or at (2)BuilderB?");
            int builderChoice = Convert.ToInt32(Console.ReadLine());

            Car myCar = new Car("911 Carrera GTS", "Porsche", "V6 Biturbo");
            Console.WriteLine("old car: " + myCar.ToString());

            CarBuilder carBuilder;
            if (builderChoice == 1)
            {
                carBuilder = new BuilderA(myCar);
                CarAssembler.Tune(carBuilder);
            }
            else if(builderChoice == 2)
            {
                carBuilder = new BuilderB(myCar);
                CarAssembler.Tune(carBuilder);
            }
            else
            {
                throw new ArgumentException();
            }

            Console.WriteLine("new car: " + myCar.ToString());
            Console.ReadLine();

        }
    }
}
