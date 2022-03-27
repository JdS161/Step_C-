using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20220206
{
    internal class Money
    {

        public string CurrencyCode { get; set; }    
        public double Amount { get; set; }  

        public Money(string _currencyCode, double _amount)
        {
            CurrencyCode = _currencyCode;   
            Amount = _amount;
        }

        public override string ToString()
        {
            return $"{Amount} {CurrencyCode}";
        }
        
        
        
        
        public delegate double MoneyConverDelegate(double _value);

        public void MakeConverOperation(MoneyConverDelegate _del)
        {
            if (_del != null)
            {
                double res = _del(Amount);
                Console.WriteLine($"{this} - converting -> {res}");
            }
            else
            {
                Console.WriteLine("Empty operation received");
            }
        }
    }
}
