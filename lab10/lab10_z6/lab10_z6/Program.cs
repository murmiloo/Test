using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab10_z6
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(Run);
            t.Start();
            //t.Join();
            Console.WriteLine("Thread t has ended!");
            Console.ReadLine();
        }
        static void Run()
        {
            for (int i = 0; i < 777; i++) Console.Write("");
        }
    }
}
// output: po usunieciu t.Join() napis "Thread t has ended!" wyswietla sie przed znakami zapytania
