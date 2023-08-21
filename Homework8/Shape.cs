using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    abstract class Shape : IComparable<Shape>
    {
        string name;

        public string Name { get { return name; } }

        public Shape(string name)
        {
            this.name = name;
        }

        abstract public double Area();
        abstract public double Perimetr();
        public abstract int CompareTo(Shape other);
    }
}