using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СW_20220123_Simulation
{
    internal class Student : Human
    {
        public Student(string _name): base(_name){ }
        public override void Evacuation()
        {
            Console.WriteLine($"Student {Name} gets up, collects the stuff, ecaluates according to the plan");
        }

        public override string ToString()
        {
            return $"Student {Name}";
        }
    }
}
