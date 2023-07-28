using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Laptop: IConnectable, IRechargeable, IDisplayable
    {
        public bool Connect()
        {
            Console.WriteLine("Laptop is connected.");
            return true;
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"Laptop is charging for {minutes} minutes.");
        }

        public string Display()
        {
            return " Display information of Laptop";
        }
    }
}
