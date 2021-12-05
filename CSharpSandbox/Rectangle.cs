using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    //  inheritance from Shape class
    class Rectangle : Shape, IDrawable
    {
        private double a, b;

        //Constructors
        public Rectangle()
        {
            a = b = 0;
        }

        public Rectangle(string _name, double _a, double _b) : base(_name, (_a+_b) *2, _a * _b)
        {
            this.a = _a;
            this.b = _b;
        }

        public override string ToString()
        {
            return base.ToString() + $", a = {a}, b={b}";
        }


        //public /*override*/ void Draw() //can be called eigher from inherit class - either from base class
        //{
        //    for (int i = 0; i < b; i++)
        //    {
        //        for (int j = 0; j < a; j++)
        //        {
        //            Console.Write("* ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        public void Draw()
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public double GetDiagonal()
        {
            return Math.Sqrt(a*a + b*b);
        }


        //abstruct method
        public override void UpdatePS()
        {
            p = (a + b) * 2;
            s = a * b;
        }
    }
}
