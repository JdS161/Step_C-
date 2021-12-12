using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20211212
{
    abstract class Figure
    {
        public string Name { get; set; }

        public Figure() { Name = "UNDEFINED"; }
        public Figure(string _name) { Name = _name; }



        public abstract double P();
        public abstract double S();
    }
}
