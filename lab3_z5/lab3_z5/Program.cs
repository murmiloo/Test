using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum samogloski {a, ą, e, ę, i, o, u, y};

namespace lab3_z5
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "111";
            int temp = 0;

            while (data != "-1")
            {
                Console.WriteLine("Wprowadz znak:");
                data = Console.ReadLine();
                if (data != "-1")
                {
                    if (Enum.IsDefined(typeof(samogloski), data))
                        Console.WriteLine("Znak to samogloska");
                    else if (int.TryParse(data, out temp))
                        Console.WriteLine("Znak to liczba");
                    else
                        Console.WriteLine("Blad");
                }
            }
        }
    }
}
