using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_z7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dziesiec = 10;
            //pojawienie bledu na etapie kompilacji
            Console.WriteLine(checked(2147483647 + dziesiec));
            //pojawienie bledu podczas wykonania
            try
            {
                Console.WriteLine(checked(2147483647 + dziesiec));
            }

            catch
            {
                Console.WriteLine("Przepelnienie");
            }
        }
    }
}
