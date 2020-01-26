using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab10_z3
{
    class ThreadTest
    {
        bool done;
        static void Main()
        {
            ThreadTest test = new ThreadTest();
            new Thread(test.Run).Start();
            test.Run();
            Console.ReadLine();
        }
        // Zauważ, że Run jest teraz metodą instancji
        void Run()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}

//output: Done wypisal sie 1 raz
