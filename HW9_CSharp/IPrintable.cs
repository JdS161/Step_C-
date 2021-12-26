using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    interface IPrintable
    {
        void Print();
        void PrintLine()
        {
            Print();
            Console.WriteLine();
        }
    }
}
