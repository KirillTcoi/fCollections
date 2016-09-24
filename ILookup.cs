using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Priv
    {
        public int Nomber { get; set; }
        public string Hiq { get; set; }
    }
    class ILookup
    {
        static void Main(string[] args)
        {
            
            List<Priv> packages = new List<Priv> { new Priv { Nomber = 1, Hiq = "Hi" },
                                                   new Priv { Nomber = 2, Hiq = "Fu" },
                                                   new Priv { Nomber = 3, Hiq = "qq" },
                                                   new Priv { Nomber = 4, Hiq = "Privet" } };
            ILookup<int, string> Hello = packages.ToLookup(p => p.Nomber, p => p.Hiq);
            foreach (var packageGroup in Hello)
            {
                Console.Write(packageGroup.Key);
                foreach (string str in packageGroup)

                    Console.WriteLine(". {0}", str);
            }
            Console.ReadKey();
        }
    }
}
