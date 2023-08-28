using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewokr9_1
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
        int IComparable<Shape>.CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }
    }
}