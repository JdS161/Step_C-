using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20211226
{
    class Curve
    {
        public string Name { get; set; }
        
        public List<Point3D> points;

        public Curve(string _name)
        {
            Name = _name;
            points = new List<Point3D>();
        }

        public void AddPoint(Point3D _point)
        {
            points.Add(_point);
        }

        public override string ToString()
        {
            string res = Name + "{";
            foreach (Point3D point in points)
            {
                res += point.ToString() + ", ";
            }
            res += "}";

            return res;
        }
        //idexer for point[i]
        public Point3D this[int _index]
        {
            get
            {
                return points[_index];
            }
            set
            {
                points[_index] = value;
            }
        }


        //indexer 
        public double this[int _i, int _j]
        {
            get
            {
                return points[_i][_j];
            }
            set
            {
                points[_i][_j] = value;
            }
        }

        public Point3D this[string  _name]
        {
            get
            {
                foreach (Point3D point in points)
                {
                    if (point.Name == _name)
                    {
                        return point;
                    }
                }
                   return null;
            }
        }
    }
}
