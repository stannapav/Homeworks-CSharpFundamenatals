using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        String Tool { get; }

        void Create(string something);

        void Destroy(string something);
    }
}