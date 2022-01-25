using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СW_20220123_Simulation
{
    internal abstract class Human
    {
        public string Name { get; set; }

        public Human(string _name)
        {
            Name = _name;
        }

        public abstract void Evacuation();


        //method of simulation of cansellation of evacuation
        public void CancelEvacuation()
        {
            Console.WriteLine($"{Name} cancelled evacuation");
        }

    }
}
