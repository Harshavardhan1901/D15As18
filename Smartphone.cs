using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Smartphone:IConnectable,IRechargeable,IDisplayable
    {
        public bool Connect()
        {
            Console.WriteLine("Smartphone is connected.");
            return true;
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"Smartphone is charging for {minutes} minutes.");
        }

        public string Display()
        {
            return "Display information of Smartphone";
        }
    }
}
