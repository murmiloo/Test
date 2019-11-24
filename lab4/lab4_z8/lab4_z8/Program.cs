using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab1 = new int[5][];
            tab1[0] = new int[3] { 1, 2, 3 };
            tab1[1] = new int[6] { 4, 5, 6, 7, 8, 9 };
            tab1[2] = new int[4] { 10, 11, 12, 13 };
            tab1[4] = new int[5] { 14, 15, 16, 17, 18 };
            tab1[5] = new int[3] { 19, 20, 21 };

            int[][] tab2 =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7, 8, 9 },
                new int[] { 10, 11, 12, 13 },
                new int[] { 14, 15, 16, 17, 18 },
                new int[] { 19, 20, 21 }
            };
        }
    }
}
