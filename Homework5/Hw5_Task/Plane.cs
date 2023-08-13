using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5_Task
{
    internal class Plane : IFlyable
    {
        string mark;
        string highFly;

        Plane(string mark, string highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine($"Plane {mark} max high of flying is {highFly}");
        }

        public static Plane Input()
        {
            Console.Write("Enter mark of the plane: ");
            string mark = Console.ReadLine();
            Console.Write($"How high {mark} can fly: ");
            string highFly = Console.ReadLine();

            return new Plane(mark, highFly);
        }
    }
}