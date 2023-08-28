using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewokr9_1
{
    internal class Circle : Shape
    {
        double radius;
        string color;

        public Circle(string name, double radius, string color) : base(name)
        {
            this.radius = radius;
            this.color = color;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * this.radius;
        }

        public static Circle Input()
        {
            Console.Write("Enter radius of this circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter color of this circle: ");
            string color = Console.ReadLine();

            return new Circle("Circle", radius, color);
        }

        public override string ToString()
        {
            return $"This {Name} is {color} with area of {Area():F2} and perimetr of {Perimetr():F2}";
        }
    }
}