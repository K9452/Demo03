using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Honda";
            vehicle.Speed = 160;
            vehicle.Tyres = 4;
            vehicle.PrintData();

           
        }
    }
}
