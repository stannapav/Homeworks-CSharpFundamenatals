using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2_AdidtionalTask
{
    enum Food { fish = 1, mouse, meat, bird, feed }

    class Cat
    {
        string name;
        int age;
        int fullness;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.fullness = 0;
        }

        public void EatSomething(Food something)
        {
            switch (something)
            {
                case Food.fish:
                    this.fullness += 5;
                    Console.WriteLine($"{this.name} ate {Food.fish}");
                    break;

                case Food.mouse:
                    this.fullness += 3;
                    Console.WriteLine($"{this.name} ate {Food.mouse}");
                    break;

                case Food.meat:
                    this.fullness += 10;
                    Console.WriteLine($"{this.name} ate {Food.meat}");
                    break;

                case Food.bird:
                    this.fullness += 7;
                    Console.WriteLine($"{this.name} ate {Food.bird}");
                    break;

                case Food.feed:
                    this.fullness += 15;
                    Console.WriteLine($"{this.name} ate {Food.feed}");
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }

        public bool checkFullness()
        {
            Console.WriteLine((this.fullness >= 30) ? $"{this.name} is full" : $"{this.name} isn't full");
            return (this.fullness >= 30) ? true : false;
        }
    }
}
