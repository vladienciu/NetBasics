using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            EngineStruct engine = new EngineStruct();
            ICar car = new Mercedes();            AbstractCar car2 = new Mercedes();            Mercedes mercedes = new Mercedes();            Mercedes.StartEngine();

            Mercedes m1 = new Mercedes();
            Console.WriteLine("Remaining km: " + m1.ShowRemainingNoOfKM(13, 8));

            Mercedes m2 = new Mercedes();
            m2.StartEngine(10);

            double km = m2.CalculateConsumption(10);
            Console.WriteLine(km);


            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);

            Console.WriteLine("This is my first C# project!");
            Console.ReadKey();        }
    }
}



