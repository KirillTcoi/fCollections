using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEqualityComparer
{
    class IEqualityComparer
    {
        static void Main()
        {
            BoxEqualityComparer Hi = new BoxEqualityComparer();

            var box = new Dictionary<Box, string>(Hi);

            var Box1 = new Box(1);
            AddBox(box, Box1, "Q");

            var Box2 = new Box(2);
            AddBox(box, Box2, "Hi");

            var Box3 = new Box(3);
            AddBox(box, Box3, "Huy");

            var Box4 = new Box(3);
            AddBox(box, Box4, "Greenadeer");

            var Box5 = new Box(4);
            AddBox(box, Box5, "Nop");

            Console.WriteLine("{0} элементов ", box.Count);
            Console.ReadKey();
        }

        private static void AddBox(Dictionary<Box, String> dict, Box box, String name)
        {
            try
            {
                dict.Add(box, name);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Объект с индексом {0} уже добавлен ", box);
            }
        }
    }

    public class Box
    {
        public Box(int n)
        {
            this.Nomber = n;
        }

        public int Nomber { get; set; }
        public override String ToString()
        {
            return String.Format("({0})", Nomber);
        }
    }

     
    class BoxEqualityComparer : IEqualityComparer<Box>
    {
        public bool Equals(Box b1, Box b2)
        {
            if (b2 == null && b1 == null)
                return true;
            else if (b1 == null | b2 == null)
                return false;
            else if (b1.Nomber == b2.Nomber)
                return true;
            else
                return false;
        }

        public int GetHashCode(Box bx)
        {
            int hCode = bx.Nomber;
            return hCode.GetHashCode();
        }
    }
}

