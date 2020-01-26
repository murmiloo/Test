using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_z2
{
    class Program
    {
        public class class1
        {
            public delegate void char_detect(string input);
            public event char_detect if_char;
            public delegate void int_detect(string input);
            public event int_detect if_int;
            public void check(string input)
            {
                try
                {
                    if (Char.IsNumber(input, 0) == true)
                    {
                        if_int("Wciśnięto cyfrę");
                    }
                    else if (Char.IsLetter(input, 0) == true)
                    {
                        if_char("Wciśnięto literę");
                    }
                    else
                    {
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                }
                catch
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
        }
                static void Main(string[] args)
                {
                    string data;
                    class1 klasa = new class1();
                    klasa.if_int += (s) => { Console.WriteLine(s); };
                    klasa.if_char += (s) => { Console.WriteLine(s); };
                    while (true)
                    {
                        data = Console.ReadLine();
                        klasa.check(data);
                    }
                }
    }
}
