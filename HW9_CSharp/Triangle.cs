using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Triangle : Figure
    {
        public double SideAB { get; set; }
        public double SideBC { get; set; }
        public double SideCD { get; set; }
        public double AngleABC { get; set; }
        public double AngleBCA { get; set; }
        public double AngleCAB { get; set; }
        

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
