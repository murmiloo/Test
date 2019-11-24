using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_z1_2
{
    public class Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
    }
    class Program
    {
        static void Fun5(Point p)
        {
            Point p2 = new Point(1, 1);
            p = p2;
        }
        static void Fun6(ref Point p)
        {
            Point p2 = new Point(10, 10);
            p = p2;
        }
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point();
            //&point2 = null; blad przy przypisaniu


            Console.WriteLine("Punkt: x={0}, y={1}", point1.x, point1.y);
            Program.Fun5(point1);
            Console.WriteLine("Punkt z Fun5: x={0}, y={1}", point1.x, point1.y);
            Program.Fun6(ref point1);
            Console.WriteLine("Punkt z Fun6: x={0}, y={1}", point1.x, point1.y); // udane przekazanie przez referencje

        }
    }
}
