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
}
public class Point
{
    public int x, y;
    public Point(int p1, int p2)
    {
        x = p1;
        y = p2;
    }

}

namespace lab3_z8
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
            Coords coord = new Coords(1, 2);
            Point point = new Point(1, 2);

            Console.WriteLine("Wspolrzedne: x={0} y={1}, Punkt: x={2} y={3}", coord.x, coord.y, point.x, point.y);
            Fun1(point);
            Fun2(coord);
            Console.WriteLine("Wspolrzedne: x={0} y={1}, Punkt: x={2} y={3}", coord.x, coord.y, point.x, point.y);
            Console.ReadLine();
            //Wartosci zostaly inkrementowane tylko dla klas. Dzieje sie tak dlatego, ze funkcje dzialaja na rzeczywistym obiekcie klas.
        }
    }
}
