using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z3
{
    class Program
    {
        unsafe static void insert(int* tab_addr, int val)
        {
            int[] tab1 = new int[10];
            for (int i = 10; i > 0; i--)
                *(tab_addr + i) = *(tab_addr + i - 1);
            *(tab_addr) = val;
        }
        unsafe static void print_tab(int* tab_addr)
        {
            for (int i = 0; i < 10; i++)
                Console.Write("{0}, ", *(tab_addr + i));
            Console.WriteLine("");
        }
        unsafe static void Main(string[] args)
        {
            int[] tab = new int[10];
            int val;
            string input = null;
            fixed (int* tab_ptr = tab)
            {
                while (input != "-1")
                {
                    Console.WriteLine("Wprowadz wartosc:");
                    input = Console.ReadLine();
                    if (input != "-1")
                    {
                        int.TryParse(input, out val);
                        insert(tab_ptr, val);
                        print_tab(tab_ptr);
                    }
                }
            }
        }
    }
}
