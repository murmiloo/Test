using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z1
{
    class Program
    {
        static void Fun1(in int i)
        {
            //i=1; nie mozna modyfikowac zmiennych wewnatrz metody, ktora przyjmuje modyfikator in
        }
        static void Fun2(out int i)
        {
            i = 2;
        }
        static void Fun3(ref int i)
        {
            i = 3;
        }
        static void Fun4(int i)
        {
            i = 4;
        }

        /*static void Fun5(in int i)
        {
            ;
        }
        static void Fun5(out int i)
        {
            ;
        }*/
        //nie mozna zdefiniowac metod, ktore roznia sie tylko modyfikatorem in/out
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("x={0}", x);
            Fun2(out x);
            Console.WriteLine("Fun2: x={0}", x);
            x = 0;
            Fun3(ref x);
            Console.WriteLine("Fun3: x={0}", x);
            x = 0;
            Fun4(x);
            Console.WriteLine("Fun4: x={0}", x);

            short y = 0;
            Console.WriteLine("y={0}", y);
            Console.WriteLine("Fun2: y={0}", y);
            y = 0;
            Console.WriteLine("Fun3: y={0}", y);
            y = 0;
            Fun4(y);
            Console.WriteLine("Fun4: y={0}", y);
            Console.ReadLine();
        }
    }
}
