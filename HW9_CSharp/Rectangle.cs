using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Rectangle: Figure
    {

        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle()
        {
            Name = "EMPTY";
            SideA = 0;
            SideB = 0;
        }

        public Rectangle(string _name, double _sideA, double _sideB)
        {
            this.Name = _name;
            this.SideA = _sideA;
            this.SideB = _sideB;
        }
        public override double Perimeter()
        {
            return 2*(SideA+SideB);
        }

        public override double Area()
        {
            return SideA*SideB;
        }

        public override string ToString()
        {
            return $"Rectanle {Name}: Side A = {SideA}, Side B = {SideB}";
        }
    }
}
