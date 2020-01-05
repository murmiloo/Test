using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_z10
{
    class Program
    {
        static void Main(string[] args)
        {
            //niejawne
            int a = 2147483647;
            long bigNum = a;
            float a2 = 3218948190;
            double bigNum2 = a2;
            short a3 = 1;
            int bigNum3 = a3;
            long a4 = 12312321;
            float bigNum4 = a4;

            //jawne
            long a5 = 2147483647;
            int bigNum5 = (int)a5;
            double a6 = 3218948190;
            float bigNum6 = (float)a6;
            int a7 = 1;
            short bigNum7 = (short)a7;
            float a8 = 12312321;
            long bigNum8 = (long)a8;
        }
    }
}
