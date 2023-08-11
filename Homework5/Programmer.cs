using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        string name;
        string language;

        public string Tool 
        {   get { return this.language; } }

        Programmer(string name, string language) 
        {
            this.name = name;
            this.language = language;
        }

        public void Create(string something)
        {
            Console.WriteLine($"Programmer {this.name} created {something} with {this.language}");
        }

        public void Destroy(string something)
        {
            Console.WriteLine($"Programmer {this.name} destroyed {something}");
        }

        public static Programmer Input()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter language that {name} is using: ");
            string language = Console.ReadLine();

            Programmer temp = new Programmer(name, language);
            return temp;
        }

        public override string ToString()
        {
            return $"{this.name} is a programmer and uses {this.language}";
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}