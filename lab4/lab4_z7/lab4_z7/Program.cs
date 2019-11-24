using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z7
{
    class Program
    {
        unsafe static void det(int* m, int* result)
        {
            int temp1 = 0;
            int temp2 = 0;
            temp1 = (*(m) * *(m + 4) * *(m + 8)) + (*(m + 1) * *(m + 5) * *(m + 6)) + (*(m + 2) * *(m + 3) * *(m + 7));
            temp2 = -(*(m + 2) * *(m + 4) * *(m + 6)) - (*(m) * *(m + 5) * *(m + 7)) - (*(m + 1) * *(m + 3) * *(m + 8));
            *result = temp1 + temp2;
        }
        unsafe static void Main(string[] args)
        {
            int[,] tab = new int[,] { { 1, 0, -1 }, { 0, 0, 1 }, { -1, -1, 0 } };
            int result = 0;
            fixed (int* ptr = tab)
            {
                det(ptr, &result);
                Console.WriteLine("Wyznacznik jest rowny {0}", result);
                Console.ReadLine();
            }
        }
    }
}
