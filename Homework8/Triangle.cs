using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Triangle : Shape, IComparable<Shape>
    {
        double[] sides = new double[3];
        string color;

        public Triangle(string name,double[] sides , string color) : base(name)
        {
            this.sides = sides;
            this.color = color;
        }

        public override double Area()
        {
            double semiPerimetr = Perimetr() / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - sides[0]) * (semiPerimetr - sides[1]) * (semiPerimetr - sides[2]));
        }

        public override double Perimetr()
        {
            return sides[0] + sides[1] + sides[2];
        }

        public static Triangle Input()
        {
            double[] sides = new double[3];
            for (int i = 0; i < sides.Length; i++)
            {
                Console.Write($"Enter {i + 1} side of this triangle: ");
                sides[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Enter color of this triangle: ");
            string color = Console.ReadLine();

            return new Triangle("Triangle", sides, color);
        }

        public override string ToString()
        {
            return $"This {Name} is {this.color} with area of {Area():F2} and perimetr of {Perimetr():F2}";
        }

        public override int CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }
    }
}