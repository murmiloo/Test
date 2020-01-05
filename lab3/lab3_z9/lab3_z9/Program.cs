using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_z9
{
    class Program
    {
        static int Count(int a, int b, char c)
        {
            if (c == '+')
            {
                return a + b;
            }
            else if (c == '-')
            {
                return a - b;
            }
            else if (c == '*')
            {
                return a * b;
            }
            else if (c == '/')
            {
                return a / b;
            }
            else
            {
                return -1;
            }
        }
        static bool IsSymbol(char c)
        {
            if (c == '+')
            {
                return true;
            }
            else if (c == '-')
            {
                return true;
            }
            else if (c == '*')
            {
                return true;
            }
            else if (c == '/')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsNumber(char a)
        {
            if (a == '0' || a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczby i znak miedzy nimi (+, -, *, /)");
            string data = Console.ReadLine();
            int result = 0;
            int right = 0;
            bool leftSide = true;
            bool isSomethingOnCurrent = false;
            char symbol = ' ';
            for (int i = 0; i < data.Length; i++)
            {
                if (leftSide && !isSomethingOnCurrent && IsNumber(data[i]))
                {
                    isSomethingOnCurrent = true;
                    result = Int32.Parse(data[i].ToString());
                }
                else if (leftSide && isSomethingOnCurrent && IsNumber(data[i]))
                {
                    result = 10 * result + Int32.Parse(data[i].ToString());
                }
                else if (leftSide && isSomethingOnCurrent && IsSymbol(data[i]))
                {
                    symbol = data[i];
                    leftSide = false;
                    isSomethingOnCurrent = false;
                }
                else if (!leftSide && !isSomethingOnCurrent && IsNumber(data[i]))
                {
                    isSomethingOnCurrent = true;
                    right = Int32.Parse(data[i].ToString());
                }
                else if (!leftSide && isSomethingOnCurrent && IsNumber(data[i]))
                {
                    right = 10 * right + Int32.Parse(data[i].ToString());
                }
                else if (!leftSide && isSomethingOnCurrent && IsSymbol(data[i]))
                {
                    result = Count(result, right, symbol);
                    symbol = data[i];
                    isSomethingOnCurrent = false;
                }
                else
                {
                    Console.WriteLine("Blad");
                    break;
                }

                if (i == data.Length - 1)
                {
                    if (IsNumber(data[data.Length - 1]))
                    {
                        result = Count(result, right, symbol);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Blad");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
