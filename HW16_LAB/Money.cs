using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16_LAB
{
    internal class Money
    {
        string CurrencyCode { get; set; }
        double Amount { get; set; } 


        public Money(string _currency, double _amount)
        {
            CurrencyCode = _currency;
            Amount = _amount;
        }


        public override string ToString()
        {
            return $"{Amount} {CurrencyCode}";
        }

        public delegate double MoneyConverDelegate(double _value);

        public void MakeConvertOperation(MoneyConverDelegate _dels)
        {
            if (_dels != null)
            {
                foreach (MoneyConverDelegate del in _dels.GetInvocationList())
                {
                    double res = del(Amount);
                    Console.WriteLine($"{this} - converting -> {res}");
                }
            }
            else
            {
                Console.WriteLine("Empty operation received");
            }
        }

    }
}
