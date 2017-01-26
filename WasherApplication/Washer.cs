using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Washer
    {
        public bool IsOn { get; set; }
        public int WaterTemperature { get; set; }
        public string WashingMode { get; set; }
        public bool Spin { get; set; }
        public double WashingTime { get; set; }
        public bool WashReady { get; set; }
        public bool WaterOn { get; set; }
    }
}
