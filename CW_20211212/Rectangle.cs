using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20211212
{
    class Rectangle : Figure, IConsolePrintable, IConsoleDrawable
    {
        public double A { get; set; }
        public double B { get; set; }

        Rectangle()
        {
            A = 0;
            B = 0;
        }

        public Rectangle(string _name,double _a, double _b)
        {
            Name = _name;
            A = _a;
            B = _b;
        }

        public override double P()
        {
            return (A + B) * 2;
        }
        public override double S()
        {
            return A * B;
        }

        //IConsolePrintable implementation
        public void Print()
        {
            Console.WriteLine(this);
        }
        public void ConsoleDraw()
        {
            for (int i = 0; i < B; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    Console.Write('*');
                }Console.WriteLine();
            }
        }
        public override string ToString()
        {
            return $"Rectangle {Name}: A = {A}, B = {B}";
        }
    }
}
