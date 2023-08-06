using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Car
    {
        const string COMPANY_NAME = "Hyundai";
        string model;
        string color;
        double price;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car()
        {
            this.model = "Tucson";
            this.color = "red";
            this.price = 8000;
        }

        public Car(string model, string color, double price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }

        public static Car Input(int i)
        {
            Console.Write($"Enter {i + 1} car model: ");
            string name = Console.ReadLine();
            Console.Write($"Enter {i + 1} car color: ");
            string color = Console.ReadLine();
            Console.Write($"Enter {i + 1} car price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Car car = new Car(name, color, price); 
            return car;
        }

        public void Print() 
        {
            Console.WriteLine($"{this.color} {COMPANY_NAME} {this.model} price of {this.price}");
        }

        public void ChangePrice(double x)
        {
            this.price -= this.price * x / 100;
        }

        public override string ToString()
        {
            return $"{this.color} {COMPANY_NAME} {this.model} price of {this.price}";
        }

        public static bool operator == (Car first, Car second)
        {
            return (first.model.ToLower().Trim() == second.model.ToLower().Trim()) && 
                (first.color.ToLower().Trim() == second.color.ToLower().Trim());
        }

        public static bool operator !=(Car first, Car second)
        {
            return !(first == second);
        }

    }
}
