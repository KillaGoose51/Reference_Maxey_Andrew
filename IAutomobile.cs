using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Maxey_Andrew
{

    // Interface tells a class what it has
    // The class can edit the method so its doesnt edit all
    internal interface IAutomobile
    {
        // public/private,type variableName = value;
        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringify();
    }
}
