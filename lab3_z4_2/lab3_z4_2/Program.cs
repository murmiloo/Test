using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_z4_2
{
    class Program
    {
        private enum range1
        {
            small = 0,
            medium = 10,
            big = 100
        }

        private static range1 CheckSize(int liczba)
        {
            range1 range = range1.small;

            foreach (range1 aa in Enum.GetValues(typeof(range1)))
            {
                if (Convert.ToInt16(aa) <= liczba)
                    range = aa;
            }

            return range;
        }
        static void Main(string[] args)
        {
            string data = "111";

            while (data != "-1")
            {
                Console.WriteLine("Wprowadz liczbe");
                data = Console.ReadLine();
                if (data != "-1")
                {
                    range1 wynik = CheckSize(Int32.Parse(data));
                    Console.WriteLine("Liczba to {0}", wynik);
                }
            }
        }
    }
}
