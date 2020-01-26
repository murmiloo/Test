using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab10_z2
{
    class Program
    {
        static void Main()
        {
            new Thread(Run).Start();
            Run();
            Console.ReadLine();
        }
        // Uruchom Run w innym wątku
        // Uruchom Run w głownym wątku
        static void Run()
        {
            // Deklaracja i użycie zmiennej lokalnej - 'cycles'
            for (int cycles = 0; cycles < 5; cycles++) Console.Write('x');
        }
    }
}

// output: x zostalo wypisane 10 razy - petla for uruchomila sie 2 razy
