using System.Runtime.InteropServices;
using System.Transactions;

namespace Reference_Maxey_Andrew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Sedan myFirstSedan = new Sedan(0, "Yes");
            IAutomobile myAutomobile = myFirstSedan;
            Sedan myOtherSedan = new Sedan(0,"No");

            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            Truck myTruck = new Truck(50, 500, "MyTruck");

            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
            // Type, Name, Makes object, (values/arguements).
            Sedan andrewscar = new Sedan(50, "Yolo");
            // andrewscar is the object, period lets us call the method/variables, Speed is the property, Pulling properties from the sedan class which andrewscar is made on
            Console.WriteLine(andrewscar.Speed + " " + andrewscar.LicensePlate);
            Console.WriteLine("Type the speed of the car");
            double fast = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You are going fast at " + fast + " miles an hour!");
            Console.WriteLine("You are slowing down going " + andrewscar.Speed + " now.");
            andrewscar.DecreaseSpeed();
            Console.WriteLine("You are slowing down going " + andrewscar.Speed + " now.");
            andrewscar.DecreaseSpeed();
            Console.WriteLine("You are slowing down going " + andrewscar.Speed + " now.");
            andrewscar.DecreaseSpeed();
            Console.WriteLine("You are slowing down going " + andrewscar.Speed + " now.");
            andrewscar.DecreaseSpeed();
            Console.WriteLine("You are slowing down going " + andrewscar.Speed + " now.");
            andrewscar.DecreaseSpeed();
            Console.WriteLine("You are slowing down going " + andrewscar.Speed + " now.");
        }
    }
}