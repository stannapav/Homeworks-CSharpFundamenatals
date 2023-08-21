using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Square : Shape
    {
        double side;
        string color;

        public Square(string name, double side, string color) : base(name)
        {
            this.side = side;
            this.color = color;
        }

        public override double Area()
        {
            return Math.Pow(this.side, 2);
        }

        public override double Perimetr()
        {
            return 4 * this.side;
        }

        public static Square Input()
        {
            Console.Write("Enter side of this square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter color of this square: ");
            string color = Console.ReadLine();
            
            return new Square("Square", side, color);
        }

        public override string ToString()
        {
            return $"This {Name} is {this.color} with area of {Area():F2} and perimetr of {Perimetr():F2}";
        }
    }
}