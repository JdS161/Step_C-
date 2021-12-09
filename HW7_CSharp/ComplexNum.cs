using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_CSharp
{
    struct ComplexNum
    {
        public double numA;
        public double numB;
        static double i = Math.Sqrt(-1);

        public ComplexNum(double _numA, double _numB)
        {
            this.numA = _numA;
            this.numB = _numB;
        }

        public override string ToString()
        {
            if (numB > 0)
            {
                return $"{numA} + {numB}i";
            }
            else
            {
                return $"{numA} - {Math.Abs(numB)}i";
            }

        }

    }
}
