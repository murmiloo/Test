using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_z5
{
    abstract class Home
    {
        public Home(int pr)
        {
            price = pr;
        }
        public int price;
        abstract public int Price();
    }

    class Home2 : Home
    {
        public Home2(int pr) : base(pr) { }
        public override int Price()
        {
            return price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie5");
        }
    }
}
