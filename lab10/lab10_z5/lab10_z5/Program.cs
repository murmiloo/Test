using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab10_z5
{
    class Program
    {
        static readonly object locker = new object();
        static void Main(string[] args)
        {
            new Thread(Run).Start();
            Run();
        }
        static void Run()
        {
            lock (locker)
            {
                //exclusive lock
            }
        }
    }
}
