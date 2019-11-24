using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z5
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] tab = { 3, 2, 3, 4, 7 };
            int count = 0;
            int flag = 0;
            int? elem = null;
            fixed (int* ptr = tab)
            {
                for (int i = 0; i < 5; i++)
                {
                    elem = *(ptr + i);
                    for (int j = 0; j < 5; j++)
                    {
                        if (i != j)
                        {
                            if (elem == *(ptr + j) & elem != -1 & *(ptr + j) != -1)
                            {
                                *(ptr + j) = -1;
                                flag = 1;
                            }

                        }
                    }
                    if (flag == 1)
                    {
                        count++;
                        flag = 0;
                    }
                }
            }
            Console.WriteLine("counter: {0}", count);
        }
    }
}
