using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    //base class of Shape
    abstract class Shape
    {
        //class fields
        protected string name;  
        protected double p;     //Perimeter
        protected double s;     //Area


        //Properties
        public double P
        {
            get
            {
                return p;
            }
        }

        public double S
        {
            get
            {
                return s;
            }
        }

        public string Name { get; set; }

        //Constructors
        public Shape()
        {
            name = "Empty";
            p = s = 0;
        }

        public Shape(string _name, double _p, double _s)
        {
            Name = _name;
            this.p = _p;
            this.s = _s;
        }


        public override string ToString()
        {
            return $"{Name}: P = {P}, S = {S}";
            //return Name + ": P= " + P.ToString() + ", S = " + S.ToString(); 
        }

        //public virtual void Draw()
        //{
        //    Console.WriteLine($"Can't draw base Shape: {ToString()} ");
        //}




        //abstract method
        public abstract void UpdatePS();

    }
}
