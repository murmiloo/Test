using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab11_z4
{
    class Program
    {
        static void Main()
        {
            ThreadPool.QueueUserWorkItem(Run);
            ThreadPool.QueueUserWorkItem(Run, 123);
            Console.ReadLine();
        }
        static void Run(object data)
        {
            Console.WriteLine("Hello !! The thread pool! " + data);
        }
    }
}
