using System;

namespace lab3
{
    class Program
    {
        static void Main()
        {
            Point2D[] p = new Point2D[5];
            double rad = 3;
            int flaga = 0;
            int number_of_point = 0;
            Point2D nastepny = new Point2D();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Podaj wartosc X dla punktu {i + 1}");
                p[i].X = double.Parse(Console.ReadLine());
                Console.WriteLine($"Podaj wartosc Y dla punktu {i + 1}");
                p[i].Y = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                p[i].Print2DPoint();
            }

            double min_dist = p[0].Dist(p[1]);

            for (int i = 0; i < 4; i++)
            {
                if (p[i].Dist(p[4]) < rad)
                    flaga++;
                else
                {
                    if (p[i].Dist(p[4]) < min_dist)
                    {
                        min_dist = p[i].Dist(p[4]);
                        number_of_point = i;
                    }
                }
            }

            if (flaga > 0)
                Console.WriteLine("Punkt lezy w jednym z okregow.");
            else
            {
                Console.WriteLine("Punkt lezy najblizej okregu {0} a odleglosc miedzy nimi to {1}", number_of_point.ToString(), min_dist.ToString());
            }
            while (flaga == 0)
            {
                Console.WriteLine("Podaj wartosc X punktu");
                nastepny.X = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc Y punktu");
                nastepny.Y = double.Parse(Console.ReadLine());

                if (p[4].Dist(nastepny) < rad)
                    flaga = 1;
                else
                {
                    Console.WriteLine("Punkt nie leży w okręgu. Podaj kolejny punkt.");
                }

            }
        }
    }
}

struct Point2D
{
    private double x;
    private double y;

    public Point2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void Reset()
    {
        this.x = 0;
        this.y = 0;
    }

    public double IncrX(double x)
    {
        this.x = this.x + x;
        return x;
    }

    public double IncrY(double y)
    {
        this.y = this.y + y;
        return y;
    }
    public void Print2DPoint()
    {
        Console.WriteLine("X={0} Y={1}", x.ToString(), y.ToString());
    }

    public double X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }
    public double Dist(Point2D second_point)
    {
        double dist_x = X - second_point.X;
        double dist_y = Y - second_point.Y;
        double dist = Math.Sqrt(Math.Pow(dist_x, 2) + Math.Pow(dist_y, 2));
        return dist;
    }
}
