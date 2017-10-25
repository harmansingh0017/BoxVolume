using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxVolumeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Boxvolumerefrence.Service1Client client = new Boxvolumerefrence.Service1Client())
            {
                Double v = client.GetVolume(4, 5, 6);
                Console.WriteLine("volume of box is :");
                Console.WriteLine(v);
                double z = client.GetSide(16, 2, 2);
                Console.WriteLine("size of box is :");
                Console.WriteLine(z);
                Console.ReadKey();
            }
        }
    }
}
