using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab11_z1
{
    class Program
    {
        static void Run() { throw null; } // Throws a NullReferenceException
        public static void Main()
        {
            try
            {
                new Thread(Run).Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }
        }
    }
}
// System.NullReferenceException: 'Odwołanie do obiektu nie zostało ustawione na wystąpienie obiektu.'

