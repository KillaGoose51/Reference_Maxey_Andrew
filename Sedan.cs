using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Maxey_Andrew
{
    internal class Sedan : IAutomobile
    {

        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        // When using the class in the class it makes a constructor, because you are giving it properities to set values too
        public Sedan(double speed, string licenseplate)
            // double speed = set the speed in program using the object's set value

            // Constructer makes it so the program knows what its setting a value too
        {
            // Speed is a properity, speed is the parameter
            Speed = speed;
            Wheels = 4;
            LicensePlate = licenseplate;
        }
        public void IncreaseSpeed()
        {
            Speed += 5;
        }
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }

        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }
    }
}
