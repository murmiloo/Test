using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Coords
{
    public int x, y;
    public Coords(int p1, int p2)
    {
        x = p1;
        y = p2;
    }
    public bool cEquals(Coords c1)
    {
        if (c1.x == x && c1.y == y)
            return true;
        else
            return false;
    }
}
public class Point
{
    public int x, y;
    public Point(int p1, int p2)
    {
        x = p1;
        y = p2;
    }
    public bool pEquals(Point p1)
    {
        if (p1.x == x && p1.y == y)
            return true;
        else
            return false;
    }
}

namespace lab3_z8_2
{
    class Program
    {
        static void Fun1(Point p)
        {
            p.x++;
            p.y++;
        }

        static void Fun2(Coords c)
        {
            c.x++;
            c.y++;
        }
        static void Main(string[] args)
        {
            Coords coord1 = new Coords(1, 2);
            Coords coord2 = new Coords(1, 2);
            Point point1 = new Point(1, 2);
            Point point2 = new Point(1, 2);

            Console.WriteLine("Wspolrzedne: Object.Equals = {0}", Object.Equals(coord1, coord2));
            Console.WriteLine("Punkt: Object.Equals = {0}", Object.Equals(point1, point2));
            Console.WriteLine("Wspolrzedne: Object.ReferenceEquals = {0}", Object.ReferenceEquals(coord1, coord2));
            Console.WriteLine("Punkt: Object.ReferenceEquals = {0}", Object.ReferenceEquals(point1, point2));
            Console.WriteLine("c.Equals 1: {0}", coord1.cEquals(coord2));
            Console.WriteLine("p.Equals 1: {0}", point1.pEquals(point2));
            Console.ReadLine();
        }
    }
}
