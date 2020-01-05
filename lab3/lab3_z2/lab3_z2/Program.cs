using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p = new Point2D();
            Console.WriteLine("Punkt to: {0}", p.ToString());
        }
    }
}

struct Point2D
{
    private double x;
    private double y;
    //public Point2D()
    //{
        //x = 0;
        //y = 0;
    //}
}
