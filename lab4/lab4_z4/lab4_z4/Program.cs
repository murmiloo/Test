using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z4
{
    class Program
    {
        unsafe static void insert(int* addr, int val)
        {
            int[] tab1 = new int[5];
            for (int i = 5; i > 0; i--)
                *(addr + i) = *(addr + i - 1);
            *(addr) = val;
        }
        unsafe static void tab_print(int* addr)
        {
            for (int i = 0; i < 5; i++)
                Console.Write("{0}, ", *(addr + i));
            Console.WriteLine("");
        }
        unsafe static void reverse(int* addr)
        {
            int j = 5;
            int[] tab1 = new int[5];
            fixed (int* tab1_ptr = tab1)
            {
                for (int i = 0; i < 5; i++)
                {
                    j--;
                    *(tab1_ptr + j) = *(addr + i);
                }
                for (int i = 0; i < 5; i++)
                {
                    *(addr + i) = *(tab1_ptr + i);
                }
            }

        }
        unsafe static void Main(string[] args)
        {
            int[] tab = new int[5];
            int val;
            string input = null;
            fixed (int* tab_ptr = tab)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Podaj wartosc:");
                    input = Console.ReadLine();
                    int.TryParse(input, out val);
                    insert(tab_ptr, val);
                }
                tab_print(tab_ptr);
                reverse(tab_ptr);
                tab_print(tab_ptr);
                Console.ReadLine();
            }
        }
    }
}
