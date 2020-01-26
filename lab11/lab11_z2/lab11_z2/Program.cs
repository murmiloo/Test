using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab11_z2
{
    class Program
    {
        public static void Main()
        {
            new Thread(Run).Start();
        }
        static void Run()
        {
            try
            {
                // ...
                throw null;
                // ...
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }
        }
    }
}
