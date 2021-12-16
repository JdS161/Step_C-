using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Parallelogram : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Heigth { get; set; }

        public Parallelogram()
        {
            Name = "EMPTY";
            SideA = 0;
            SideB = 0;
            Heigth = 0;
        }
        public Parallelogram(string _name, double _sideA, double _sideB, double _heigth)
        {
            this.Name = _name;
            this.SideA = _sideA;
            this.SideB = _sideB;
            this.Heigth = _heigth;
        }
        public override double Perimeter()
        {
            return 2*(SideA+SideB);
        }
        public override double Area()
        {
            return SideB * Heigth;
        }

        public override string ToString()
        {
            return $"Parallelogram {Name}: Side A = {SideA}, Side B = {SideB}, Heigth = {Heigth}";
        }
    }
}
