using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    internal class Mercedes : AbstractCar
    {
        public string description;
        public int price;

        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        internal string model;
        internal string culoare;

        internal string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        internal string Culoare
        {
            get
            {
                return culoare;
            }
            set
            {
                culoare = value;
            }
        }

        public static void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public void StartEngine(int ms)
        {
            Console.WriteLine("The car is starting in " + ms + " milliseconds.");
        }

        public int ShowRemainingNoOfKM(int noOfFuelLiters, int Consumption)
        {
            return noOfFuelLiters / Consumption * 100;
            // Console.WriteLine("Remaining km: " + noOfFuelLiters / Consumption * 100);
        }

        public double CalculateConsumption(params int[] kms)
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            return sum / 100 * 7;
        }

    }

}
