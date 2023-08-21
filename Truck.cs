using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Maxey_Andrew
{
    internal class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }
        public double Weight { get; }


        // parameters are the variables that are passed as arguments to a method
        // When using the class in the class it makes a constructor, because you are giving it properities to set values too
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            //speed is the property, speedParam is the param.
            Speed = speedParam;
            // weight is a properity
            Weight = weightParam;
            LicensePlate = licenseNum;
            if (Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
        // so if weight = weightParam and the arguement is 5 then the weight is 5, LicensePlate = lucenseNum and the arguement is 120 the licenseplate is 120
         
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }
    }
}
