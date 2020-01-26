using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_z5
{
    class Program
    {
        static void Main()
        {
            Func<string, int> method = Do;
            IAsyncResult cookie = method.BeginInvoke("test", null, null);
            // .. tutaj możemy równolegle wykonywać inne prace ...
            int result = method.EndInvoke(cookie);
            Console.WriteLine("String length is: " + result);
        }
        static int Do(string s) { return s.Length; }
    }
}
