using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        public void PrintData()
        {
            Console.WriteLine("Car information: ");
            Console.WriteLine("Car name " + Name);
            Console.WriteLine("Car speed " + Speed);
            Console.WriteLine("Car tyres " + Tyres);
            {
                Console.ReadLine();
            }
        }
    }
}
