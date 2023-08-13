using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5_Task
{
    internal class Bird : IFlyable
    {
        string name;
        bool canFly;

        Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }

        public void Fly()
        {
            Console.WriteLine($"Bird {name} " + ( (canFly) ? "can fly" : "cannot fly") );
        }

        public static Bird Input()
        {
            Console.Write("Enter name of the bird: ");
            string name = Console.ReadLine();
            Console.Write($"Can {name} fly?(y/n) ");
            string answer = Console.ReadLine();
            bool canFly = (answer.ToLower().Trim() == "y") ? true : false; 

            return new Bird(name, canFly);
        }
    }
}