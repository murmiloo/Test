using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_z6
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "111";

            while (data != "-1")
            {
                Console.WriteLine("Podaj napis");
                data = Console.ReadLine();
                if (data != "-1")
                {
                    for (int i = 1; i < data.Length; i = i + 2)
                        data = data.Insert(i, " ");
                    Console.WriteLine(data);
                }

            }
        }
    }
}
