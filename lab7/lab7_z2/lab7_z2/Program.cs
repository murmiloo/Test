using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_z2
{
    class point
    {
        public int x;
        public int y;
        public point(int wsp_x)
        {
            this.x = wsp_x;
            this.y = 0;
        }
        public point(int wsp_x, int wsp_y)
        {
            this.x = wsp_x;
            this.y = wsp_y;
        }
        public static point operator +(point a, point b)
            => new point(a.x + b.x, a.y + b.y);
        public static bool operator true(point a)
            => a.x == 0 || a.y == 0;
        public static bool operator false(point a)
            => a.x != 0 || a.y != 0;
        public static bool operator ==(point a, point b)
        {
            if (a.x == b.x && a.y == b.y)
                return true;
            else
                return false;
        }
        public static bool operator !=(point a, point b)
        {
            if (a.x != b.x || a.y != b.y)
                return true;
            else
                return false;
        }
        public static bool operator <(point a, point b)
        {
            if (a.x < b.x && a.y < b.y)
                return true;
            else
                return false;
        }
        public static bool operator >(point a, point b)
        {
            if (a.x > b.x && a.y > b.y)
                return true;
            else
                return false;
        }
        public static bool operator <=(point a, point b)
        {
            if (a.x <= b.x && a.y <= b.y)
                return true;
            else
                return false;
        }
        public static bool operator >=(point a, point b)
        {
            if (a.x >= b.x && a.y >= b.y)
                return true;
            else
                return false;
        }
        public static point operator ++(point a)
        {
            a.x++;
            a.y++;
            return a;
        }
        public static point operator --(point a)
        {
            a.x--;
            a.y--;
            return a;
        }
        public static implicit operator point(int a)
        {
            return new point(a);
        }
        public static explicit operator int(point p)
        {
            return p.x + p.y;
        }

        //nie mozna nadpisac operatora +=
    }
    class Program
    {
        static void Main(string[] args)
        {
            point a = new point(2, 2);
            point b = new point(4, 4);
            point c = a + b;
            point d = 5;
            int suma = (int)b;
            Console.WriteLine("x wynosi {0}, y wynosi {1}", c.x, c.y);
            Console.WriteLine(suma);
            Console.WriteLine("x wynosi {0}, y wynosi {1}", d.x, d.y);
            Console.ReadLine();
        }
    }
}
