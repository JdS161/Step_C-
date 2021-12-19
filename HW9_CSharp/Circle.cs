using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle()
        {
            Name = "EMPTY";
            Radius = 0;
        }
        public Circle(string _name, double _radius)
        {
            this.Name = _name;
            this.Radius = _radius;
        }
        public override double Perimeter()
        {
            return 2* Math.PI * Radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public override string ToString()
        {
            return $"Circle {Name} : Radius = {Radius}.";
        }
    }
}
