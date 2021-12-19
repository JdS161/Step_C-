using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        
        
        public Triangle()
        {
            Name = "EMPTY";
            SideA = 0;
            SideB = 0;
            SideC = 0;
        }

        public Triangle(string _name, double _sideA, double _sideB, double _sideC)
        {
            this.Name = _name;
            this.SideA = _sideA;
            this.SideB = _sideB;
            this.SideC = _sideC;
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double Area()
        {
            return Math.Sqrt(Perimeter() / 2 * (Perimeter() / 2 - SideA) * (Perimeter() / 2 - SideB) * (Perimeter() / 2 - SideC));
        }

        public override string ToString()
        {
            return $"Triangle {Name}: Side A ={SideA}, SIde B = {SideB}, Side C = {SideC}.";
        }
    }
}
