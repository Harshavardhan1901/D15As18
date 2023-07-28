using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            smartphone.Connect();
            smartphone.Charge(60);
            string smartphoneDisplayInfo = smartphone.Display();
            Console.WriteLine($"Smartphone Display Info: {smartphoneDisplayInfo}");

            Console.WriteLine();

            Laptop laptop = new Laptop();
            laptop.Connect();
            laptop.Charge(120);
            string laptopDisplayInfo = laptop.Display();
            Console.WriteLine($"Laptop Display Info: {laptopDisplayInfo}");

            Console.ReadKey();
        }
    }
}
