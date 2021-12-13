using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_CSharp
{
    partial class CarrierRocket
    {
       
        partial void Launch(CarrierRocket _rocket)
        {
            Console.WriteLine($"{_rocket.CarrierName} is launched!");
        }
        
        public void Launched(CarrierRocket _rocket)
        {
            Console.WriteLine();
            Launch(_rocket);
            Console.WriteLine();
        }
    }


    class CarrierRocketPool
    {
        List<CarrierRocket> rockets;

        public CarrierRocketPool()
        {
            rockets = new List<CarrierRocket>();
        }


        public void AddRocket(CarrierRocket _rocket)
        {
            rockets.Add(_rocket);
        }

        public override string ToString()
        {
            string result = "FIGURE POOL:\n";
            foreach (CarrierRocket rocket in rockets)
            {
                result += rocket.ToString() + "\n";
            }
            result += "----------------------------\n";
            return result;
        }








    }

}
