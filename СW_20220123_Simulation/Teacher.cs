using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СW_20220123_Simulation
{
    internal class Teacher : Human
    {
        public Teacher(string _name) : base(_name) {}

        public override void Evacuation()
        {
            Console.WriteLine($"Teacher {Name} gets up, closes windows, manages evacuation, etc.");
        }

        public override string ToString()
        {
            return $"Teacher {Name}";
        }



    }
}
