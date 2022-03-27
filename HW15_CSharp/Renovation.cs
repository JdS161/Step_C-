using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_CSharp
{
    internal class Renovation
    {
        string Name { get; set; }
        double Lenght { get; set; }
        double Width { get; set; }

        public Renovation( string _name, double _lenght, double _width)
        {
            Name = _name;
            Lenght = _lenght;
            Width = _width;
        }

        static double Wallpapers(Renovation _room, double _heigth)
        {
            return (_room.Width + _room.Lenght) * _heigth * 2;
        }


    }
}
