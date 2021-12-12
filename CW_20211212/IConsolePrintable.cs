using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20211212
{
    interface IConsolePrintable
    {
        void Print();       //method of an interface for printing and object to console
        void PrintLine()
        {
            Print();
            Console.WriteLine();
        }
    }
}
