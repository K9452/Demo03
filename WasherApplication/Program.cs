using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.IsOn = true;
            washer.WaterTemperature = 40;
            washer.WashingTime = 1.30;
            washer.WashingMode = "quick wash";
            washer.WaterOn = true;
            washer.Spin = false;
            washer.WashReady = true;

            Console.WriteLine("Washers power " + washer.IsOn);
            Console.WriteLine("Waters temperature is  " + washer.WaterTemperature);
            Console.WriteLine("Washing time is" + washer.WashingTime);
            Console.WriteLine("Washers mode " + washer.WashingMode);
            Console.WriteLine("Water on " + washer.WaterOn);
            Console.WriteLine("Spin mode activated " + washer.Spin);
            Console.WriteLine("Wash completed " + washer.WashReady);
        }
    }
}
