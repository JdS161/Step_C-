using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_CSharp
{
    abstract class Money
    {
        public string Currency {get; set;}
        public double Amount{get; set;}
      

        public Money()
        {
            Currency  = "NONE";
            Amount = 0;
        }

        public Money(string _currency, double _amount)
        {
            Currency  = _currency;
            Amount = _amount;            
        }
        
        abstract public void Print();




    }
}