using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Day { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7};

namespace lab3_z4
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "111";
            int flaga;
            while (data != "-1")
            {
                Console.WriteLine("Podaj numer odpowiadajacy dniu tygodnia:");
                data = Console.ReadLine();
                if (data != "-1")
                {
                    int.TryParse(data, out flaga);
                    if (flaga > 0 && flaga < 8)
                    {
                        Console.WriteLine("{0}", Enum.GetName(typeof(Day), flaga));
                    }
                    else
                        Console.WriteLine("Zly numer");
                }
            }
        }
    }
}
