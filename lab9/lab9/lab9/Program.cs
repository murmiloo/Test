using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Random losowa = new Random();
            int height = 10;
            for (int i = 0; i < height; i++)
            {
                for (int i1 = 0; i1 < height - i - 1; i1++)
                {
                    Console.Write(" ");
                }
                for (int i2 = 0; i2 < i * 2 + 1; i2++)
                {
                    char randomchar = (char)losowa.Next('0', '~');
                    Console.Write(randomchar);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int i1 = 0; i1 < height - count - 1; i1++)
                {
                    Console.Write(" ");
                }
                char randomchar = (char)losowa.Next('0', '~');
                Console.Write(randomchar);
                Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}
