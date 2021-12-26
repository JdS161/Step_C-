using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Rhombus : Figure, IPrintable

    {
        public double Side { get; set; }
        public double Heigth { get; set; }


        public Rhombus()
        {
            Name = "EMPTY";
            Side = 0;
            Heigth = 0;
        }

        public Rhombus(string _name, double _side, double _heigth)
        {
            this.Name = _name;
            this.Side = _side;
            this.Heigth = _heigth;
        }

        public override double Perimeter()
        {
            return 4*Side;
        }

        public override double Area()
        {
            return Side*Heigth;
        }

        public override string ToString()
        {
            return $"Rhombus {Name}: Side = {Side}, Heigth = {Heigth}."; 
        }

        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
