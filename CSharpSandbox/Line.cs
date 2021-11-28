using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    class Line
    {
        //descripton of the class - class members - methods and included classes
        private string lineName;
        private Point p1, p2;



        //Constructors
        public Line()
        {
            lineName = "empty";
            p1 = p2 = new Point("empty", 0, 0);
        }
        public Line(string _lineName, Point _p1, Point _p2)
        {
            this.lineName = _lineName;
            this.p1 = _p1;
            this.p2 = _p2;
        }

        //Properties - similar to GET/SET methods from C++
        public string LineName
        {//property body
            get                     //get - realization of getting a value
            {
                return lineName;
            }
            set                     //set - realization of setting a VALUE
            {
                lineName = value;
            }
        }

        public Point P1
        {
            get
            {
                return p1;
            }
            set
            {
                p1 = value;
            }
        }
        public Point P2
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
            }
        }

        

        //Distance found
        public double LineDistance()
        {
            return Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
        }

        public override string ToString()
        {
            return $"{lineName}, [{p1}, {p2}]";
        }

    }

    struct Point
    {
        public string name;
        public double x;
        public double y;

        //Constructor
        public Point(string _name, double _x, double _y)
        {
            this.name = _name;
            this.x = _x;
            this.y = _y;
        }


        //Method for determinating distance from the point to point 0
        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }



        //Overloaded mothod ToString for RETURNING of a STRING of an object
        public override string ToString()
        {
            return $"{name}({x},{y})";
        }



    }

}
