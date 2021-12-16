using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Square: Figure
    {
        public double Side { get; set; }

        public Square()
        {
            Name = "EMPTY";
            Side = 0;
        }

        public Square(string _name, double _side)
        {
            this.Name = _name;
            this.Side = _side;
        }
        public override double Perimeter()
        {
            return 4*Side;
        }

        public override double Area()
        {
            return Side*Side;
        }

        public override string ToString()
        {
            return $"Squre {Name}: Side {Side}"; 
        }
    }
}
