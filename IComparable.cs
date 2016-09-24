using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class IComparable
    {
        static void Main(string[] args)
        {
            Hello p1 = new Hello { Nomber = 1, Priv = "Q" };
            Hello p2 = new Hello { Nomber = 2, Priv = "Privet" };
            Hello p3 = new Hello { Nomber = 3, Priv = "Alloha" };

            Hello[] people = new Hello[] { p1, p2, p3 };
            Array.Sort(people, new qHello());

            foreach (Hello p in people)
            {
                Console.WriteLine("{0}. {1}", p.Nomber, p.Priv);
            }
            Console.ReadKey();
        }
    }
    class Hello : System.IComparable
    {
        public int Nomber { get; set; }
        public string Priv { get; set; }
        public int CompareTo(object o)
        {
            Hello p = o as Hello;
            if (p != null)
                return this.Priv.CompareTo(p.Priv);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
    class qHello : IComparer<Hello>
    {
        public int Compare(Hello p1, Hello p2)
        {
            if (p1.Nomber > p2.Nomber)
                return 1;
            else if (p1.Nomber < p2.Nomber)
                return -1;
            else
                return 0;
        }
    }
}
