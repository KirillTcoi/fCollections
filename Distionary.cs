using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Hello = new Dictionary<int, string>(10);
            Hello.Add(1, "Hi");
            Hello.Add(2, "Fu");
            Hello.Add(3, "qq");
            Hello.Add(4, "Privet");
            int n = 0;
            foreach (KeyValuePair<int, string> q in Hello)
            {
                Console.WriteLine(q.Key + " " + q.Value);
            }
            Console.WriteLine("~~ - Приветствие ~~ (По номеру)");
            try
            {
                Hello.Remove(int.Parse(Console.ReadLine()));
            }
            catch
            { Console.WriteLine("Неверное значение"); }
            Console.WriteLine("~~ + Приветствие ~~");
            Hello.Add(5, Console.ReadLine());
            Console.Clear();
            foreach (KeyValuePair<int, string> q in Hello)
            {
                Console.WriteLine(q.Key + " " + q.Value);
            }
            Console.ReadKey();
        }
    }
}
