using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class TV
    {
        public bool Power { get; set; }
        public string Source { get; set; }
        public string Channel { get; set; }
        public string Show { get; set; }
        public string Info { get; set; }
        public bool ChangeChannel { get; set; }
        public bool PowerOff { get; set; }
        
        public void Start()
        {
            Console.WriteLine("Starting... wait a moment");
        }
        public void Welcome()
        {
            Console.WriteLine("Hello :)");
        }
        public void Off()
        {
            Console.WriteLine("Bye Bye");
        }
    }
}
