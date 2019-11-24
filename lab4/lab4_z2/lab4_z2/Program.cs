using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z2
{
    class TestPointer
    {
        public unsafe static void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
        public unsafe static void set_val(int* buffer_address, int value, int index)
        {
            *(buffer_address + index) = value;
        }
        public unsafe static void print_val(int* buffer_address, int index)
        {
            Console.WriteLine("Value: {0}, index: {1}", *(buffer_address + index), index);
        }
        class Program
        {
            public unsafe static void Main() // nie mozna usunac unsafe
            {
                int[] list = { 10, 100, 200 };
                fixed (int* ptr = list)

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Adress [{0}] = {1}", i, (int)(ptr + i));
                        Console.WriteLine("Wartosc [{0} = {1}", i, *(ptr + i));
                    }

                int a = 11, b = 12;
                Console.WriteLine("a = {0}, b = {1}", a, b);
                swap(&a, &b);
                Console.WriteLine("a = {0}, b = {1}", a, b);

                int[] buff = new int[1024];
                int value = 50, index = 10;
                fixed (int* buff_ptr = buff)
                {
                    print_val(buff_ptr, index);
                    set_val(buff_ptr, value, index);
                    print_val(buff_ptr, index);
                }
            }
        }
    }
}
