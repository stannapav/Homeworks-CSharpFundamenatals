using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(p.x - this.x, 2) + Math.Pow(p.y - this.y, 2));
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }
    }

    public class Triangle
    {
        Point a, b, c;

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

        public double Perimeter()
        {
            return a.Distance(b) + b.Distance(c) + c.Distance(a);
        }

        public double Square() //Area???
        {
            double semiPerimeter = Perimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Distance(a, b)) * (semiPerimeter - Distance(b, c)) * (semiPerimeter - Distance(c, a)));
        }

        public void Print()
        {
            Console.WriteLine("Triangle info: ");
            Console.WriteLine($"Point a: {a}, Point b: {b}, Point c: {c}");
            Console.WriteLine($"Distacnse between a - b {a.Distance(b):F2}, b - c {b.Distance(c):F2}, c - a {c.Distance(a):F2}");
            Console.WriteLine($"Triangle perimetr: {Perimeter():F2}, square: {Square():F2}");
        }
    }
}
