using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class FiguresPool
    {
        List<Figure> figures;

        public FiguresPool()
        {
            figures = new List<Figure>();
        }

        public void AddFigure(Figure _figure)
        {
            figures.Add(_figure);
        }
        public double GetTotalPerimeter()
        {
            double totalPerimeter = 0;
            foreach (Figure figure in figures)
            {
                totalPerimeter += figure.Perimeter();
            }
            return totalPerimeter;
        }

        public double GetTotalArea()
        {
            double totalArea = 0;
            foreach (Figure figure in figures)
            {
                totalArea += figure.Area();
            }
            return totalArea;
        }

        public override string ToString()
        {
            
            string res = "FIGURE POOL:\n";
            foreach (Figure figure in figures)
            {
                res += figure.ToString() + "\n";
            }
            res += "--------------------------------------\n";

            return res;
        }

        

    }
}
