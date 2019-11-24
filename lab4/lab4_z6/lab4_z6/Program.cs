using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z6
{
    class Program
    {
        unsafe static void tab_print(int* tab_ptr)
        {
            for (int i = 0; i < 25; i++)
            {
                if (i % 5 == 0 & i != 0)
                    Console.WriteLine();
                Console.Write("{0} ", *(tab_ptr + i));
            }
            Console.WriteLine();
        }
        unsafe static void add_tab(int* tab1, int* tab2, int* result)
        {
            for (int i = 0; i < 25; i++)
            {
                *(result + i) = *(tab1 + i) + *(tab2 + i);
            }
        }
        unsafe static void Main(string[] args)
        {
            int[,] tab1 = new int[,] { { 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3 } };
            int[,] tab2 = new int[,] { { 1, 1, 1, 1, 1 }, { 2, 2, 2, 2, 2 }, { 3, 3, 3, 3, 3 }, { 4, 4, 4, 4, 4 }, { 5, 5, 5, 5, 5 } };
            int[,] result = new int[5, 5];
            fixed (int* ptr1 = tab1, ptr2 = tab2, ptr_res = result)
            {
                tab_print(ptr1);
                Console.WriteLine();
                tab_print(ptr2);
                add_tab(ptr1, ptr2, ptr_res);
                Console.WriteLine("Suma to:");
                tab_print(ptr_res);
                Console.ReadLine();
            }
        }
    }
}
