using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        string name;
        string tool;

        public string Tool
        {
            set { this.tool = value; }
            get { return this.tool; }
        }

        Builder(string name, string tool)
        {
            this.name = name;
            this.tool = tool;
        }

        public void Create(string something)
        {
            Console.WriteLine($"Builder {this.name} builtd {something} with {this.tool}");
        }

        public void Destroy(string something)
        {
            Console.WriteLine($"Builder {this.name} destroyed {something}");
        }

        public static Builder Input()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter tool that {name} is using: ");
            string tool = Console.ReadLine();
            
            Builder temp = new Builder(name, tool);
            return temp;
        }

        public override string ToString()
        {
            return $"{this.name} is a builder and uses {this.tool}";
        }


        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}