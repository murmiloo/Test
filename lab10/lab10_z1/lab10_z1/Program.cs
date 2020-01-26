using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab10_z1
{
    class ThreadExample
    {
        static void Main()
        {
            Thread t = new Thread(Write1); //Uruchom inny wątek
            t.Start();
            // Główny wątek.
            for (int i = 0; i < 1000; i++) Console.Write("0");
            Console.ReadLine();
        }
        //Inny wątek
        static void Write1()
        {
            for (int i = 0; i < 1000; i++) Console.Write("1");
        }
    }
}
