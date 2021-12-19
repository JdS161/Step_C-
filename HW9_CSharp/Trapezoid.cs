using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Trapezoid: Figure 
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        public Trapezoid()
        {
            Name = "EMPTY";
            SideA = 0;
            SideB = 0;
            SideC = 0;
            SideD = 0;
        }
        public Trapezoid(string _name, double _sideA, double _sideB, double _sideC, double _sideD)
        {
            this.Name = _name;
            this.SideA = _sideA;
            this.SideB = _sideB;
            this.SideC = _sideC;
            this.SideD = _sideD; 
        }

        public override double Perimeter()
        {
            return SideA+SideB+SideC+SideD;
        }

        public override double Area()
        {
            double heigth = (Math.Sqrt((-SideA+SideB+SideC+SideD)*(SideA-SideB+SideC+SideD)*(SideA-SideB+SideC-SideD)*(SideA-SideB-SideC+SideD)))/(2 * Math.Abs(SideB-SideA));
            return (SideA + SideB) / 2 * heigth;
        }

        public override string ToString()
        {
            return $"Trapezoid {Name}: Side A = {SideA}, Side B = {SideB}, Side C = {SideC}, Side D = {SideD}.";
        }
    }
}
