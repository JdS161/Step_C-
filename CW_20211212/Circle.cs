using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20211212
{
    class Circle : Figure
    {
        public double R { get; set; }

        public Circle()
        {
            R = 0;
        }
        public Circle(string _name, double _r)
        {
            Name = _name;
            R = _r;
        }
        public override double P()
        {
            return 2 * Math.PI * R;
        }
        public override double S()
        {
            return Math.PI * R * R;
        }

        public override string ToString()
        {
            return $"Circle {Name}: r = { R}"; 
        }
    }
}
