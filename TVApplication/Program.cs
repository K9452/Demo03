using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.Power = true;
            Console.WriteLine("TV power " + tv.Power);

            tv.Start();
            tv.Source = "HD1";
            Console.WriteLine("Source selected " + tv.Source);

            tv.Welcome();
            tv.Channel = "Yle1";
            Console.WriteLine("Selected channel " + tv.Channel);

            tv.Info = "Kotimainen klassikko elokuva";
            Console.WriteLine("Show playing int this channel " + tv.Info);

            tv.ChangeChannel = false;
            Console.WriteLine("ChangeChannel " + tv.ChangeChannel);

            tv.PowerOff = true;
            Console.WriteLine("Wanna switch power off " + tv.PowerOff);
            tv.Off();
 
            {
                Console.ReadLine();
            }
        }
    }
}
