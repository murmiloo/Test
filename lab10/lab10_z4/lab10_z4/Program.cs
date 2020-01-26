using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab10_z4
{
    class ThreadExample
    {
        static bool done;
        // Pole statyczne
        static void Main()
        {
            new Thread(Run).Start();
            Run();
            Console.ReadLine();
        }
        //static void Run(){
        //    if (!done) { done = true; Console.WriteLine ("Done"); }
        //}
        static void Run()
        {
            if (!done) { Console.WriteLine("Done"); done = true; }
        }
    }
}

// Done zostal wypisany 1 raz, po zmianie zawartosci funkcji: Done zostal wypisany 2 razy
