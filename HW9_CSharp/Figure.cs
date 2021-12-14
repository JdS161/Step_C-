using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    abstract class Figure
    {
        public string Name { get; set; }

        public Figure()
        {
            Name = "EMPTY";
        }

        public Figure (string _name)
        {
            Name = _name;
        }

        abstract public double Perimeter();
        abstract public double Area();
    }
}
