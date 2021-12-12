using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20211212
{
    class FigurePool: IConsoleDrawable, IConsolePrintable
    {
        List<Figure> figures;

        public FigurePool()
        {
            figures = new List<Figure>(); //creating an object of the list
        }

        //adding the figure to the pool
        public void AddFigure(Figure _figure)
        {
            figures.Add(_figure);
        }

        public void ConsoleDraw()
        {
            foreach (var figure in figures)
            {
                if (figure is IConsoleDrawable)
                {  
                    ((IConsoleDrawable)figure).ConsoleDraw();
                }
                else
                {
                    Console.WriteLine("Figure does not support this interface");
                }
        }

        }

        public double getTotalP()
        {
            double sum = 0;
            foreach (Figure figure in figures)
            {
                sum += figure.P();
            }
            return sum;
        }
        public double getTotalS()
        {
            double sum = 0;
            foreach (Figure figure in figures)
            {
                sum += figure.S();
            }
            return sum;
        }

        public void Print()
        {
            foreach (var figure in figures)
            {
                //call Print of the figure, if it implements IConsolePrintable
                if(figure is IConsolePrintable)
                {
                    ((IConsolePrintable)figure).Print();
                }
                else 
                {
                    Console.WriteLine("Figure does not support this interface");
                }
            }        
        }

        public override string ToString()
        {
            string res = "FIGURE POOL:\n";
            foreach (Figure figure in figures)
            {
                res += figure.ToString() + "\n";
            }
            res += "-------------------------------\n";
            return res;
        }

    }
}
