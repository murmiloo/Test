using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_z3
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "111";
            int count_int = 0;
            int count_char = 0;
            int count_string = 0;
            char napis;
            int liczba;

            while (data != "-1")
            {
                Console.WriteLine("Podaj dane:");
                data = Console.ReadLine();
                if (data != "-1")
                {
                    if (int.TryParse(data, out liczba))
                    {
                        count_int++;
                    }
                    if (char.TryParse(data, out napis))
                    {
                        count_char++;
                    }
                    else
                    {
                        count_string++;
                    }
                }
            }
            Console.WriteLine("Ilosc konwersji: int={0}, char={1}, string={2}", count_int, count_char, count_string);
            Console.ReadLine();
        }
    }
}
