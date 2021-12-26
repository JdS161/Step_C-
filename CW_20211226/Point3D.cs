using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20211226
{
    class Point3D
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D()
        {
            Name = "EMPTY";
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point3D(string _name, double _x, double _y, double _z)
        {
            Name = _name;
            X = _x;
            Y = _y;
            Z = _z;
        }

        //indexer of the point do access to the coordinates via idexes

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    default: throw new IndexOutOfRangeException("Unaceptable ndex for a point");
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        X = value;
                        break;
                     case 1:
                        Y = value;
                        break;
                     case 2:
                        Z = value;
                        break;
                                        
                    default: throw new IndexOutOfRangeException("Unaceptable ndex for a point");
                }
            }
        }


        public override string ToString()
        {
            return $" {Name} : ({X}, {Y}, {Z});"; 
        }



    }
}
