using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_z3
{
    class Program
    {
        static void Main()
        {
            Task.Factory.StartNew(Run);
            Console.ReadLine();
        }
        static void Run()
        {
            Console.WriteLine("Hello !! The thread pool!");
        }
    }
}
