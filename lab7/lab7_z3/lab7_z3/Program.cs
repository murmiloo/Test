using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_z3
{
    class Program
    {
        class class1
        {
            public void add(int x, int y)
            {
                Console.WriteLine("{0}+{1}={2}", x, y, x + y);
            }
            public void subtract(int x, int y)
            {
                Console.WriteLine("{0}-{1}={2}", x, y, x - y);
            }
            public void multiple(int x, int y)
            {
                Console.WriteLine("{0}*{1}={2}", x, y, x * y);
            }
            public void divide(int x, int y)
            {
                Console.WriteLine("{0}/{1}={2}", x, y, x / y);
            }
        }
        public delegate void action(int x, int y);
        static void Main(string[] args)
        {
            class1 class11 = new class1();
            action act = new action(class11.add);
            act(1, 2);
            act = class11.subtract;
            act(8, 4);
            act = class11.multiple;
            act(2, 2);
            act = class11.divide;
            act(2, 1);
            Console.ReadLine();
        }
    }
}
