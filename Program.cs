using System.Runtime.InteropServices;

namespace Reference_Maxey_Andrew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Type, Name, Makes object, (values).
            Sedan andrewscar = new Sedan(50, "Yolo");
            // andrewscar is the objec, period lets us call the method/variables, Speed is the property 
            Console.WriteLine(andrewscar.Speed + " " + andrewscar.LicensePlate);
            Console.WriteLine("Type the speed of the car");
            double fast = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You are going fast at "+fast+" miles an hour!");
            Console.WriteLine("You are slowing down going "+speed+" now");




        }
    }
}