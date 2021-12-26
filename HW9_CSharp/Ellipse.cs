using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Ellipse : Figure, IPrintable
    {
        public double HalfAxisSmall { get; set; }
        public double HalfAxisBig { get; set; }

        public Ellipse()
        {
            Name = "EMPTY";
            HalfAxisSmall = 0;
            HalfAxisBig = 0;
        }
        public Ellipse(string _name, double _halfAxisSmall, double _halfAxisBig)
        {
            this.Name = _name;
            this.HalfAxisSmall = _halfAxisSmall;
            this.HalfAxisBig = _halfAxisBig;
        }

        public override double Perimeter()
        {
            return Math.PI*(3*(HalfAxisSmall+HalfAxisBig) - Math.Sqrt((3*HalfAxisSmall+HalfAxisBig)*(HalfAxisSmall+3*HalfAxisBig)));
        }
        public override double Area()
        {
            return Math.PI*HalfAxisSmall*HalfAxisBig;
        }

        public override string ToString()
        {
            return $"Ellipse {Name}: Small half-axis = {HalfAxisSmall}, Big half-axis = {HalfAxisBig}.";
        }

        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
