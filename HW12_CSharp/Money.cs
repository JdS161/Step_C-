using System;
namespace HW12_CSharp
{
    public class Money
    {
        public string Currency { get; set; }
        public double Amount { get; set; }

        public Money()
        {
            Currency = "NONE";
            Amount = 0;
        }

        public Money(string _currency, double _amount)
        {
            Currency = _currency;
            Amount = _amount;
        }

        public static Money operator +(Money _lMoney, Money _rMoney)
        {
            Money res = new Money();
            if(_lMoney.Currency != _rMoney.Currency)
            {
                Console.WriteLine("Impossible to sum money with different currencies");
                return res;
            }
            else
            {
                res.Amount = _lMoney.Amount + _rMoney.Amount;
                res.Currency = _lMoney.Currency;
                return res;
            }
        }
        public static Money operator -(Money _lMoney, Money _rMoney)
        {
            Money result = new Money();
            if (_lMoney.Currency != _rMoney.Currency)
            {
                Console.WriteLine("Impossible to subtract money with different currencies");
                return result;
            }
            else
            {
                if (_lMoney.Amount > _rMoney.Amount)
                {
                    result.Amount = _lMoney.Amount - _rMoney.Amount;
                }
                else if (_rMoney.Amount > _lMoney.Amount)
                {
                    result.Amount = _rMoney.Amount - _lMoney.Amount;
                }
                result.Currency = _lMoney.Currency;
                return result;
            }
        }
        public static Money operator /(Money _lMoney, int _num)
        {
            Money res = new Money();
            res.Amount = _lMoney.Amount / _num;
            res.Currency = _lMoney.Currency;
            return res;
        }
        public static Money operator *(Money _lMoney, int _num)
        {
            Money res = new Money();
            res.Amount = _lMoney.Amount * _num;
            res.Currency = _lMoney.Currency;
            return res;
        }
        public static Money operator ++(Money _lMoney)
        {
            Money res = new Money();
            res.Amount = _lMoney.Amount + 0.01;
            res.Currency = _lMoney.Currency;
            return res;
        }
        public static Money operator --(Money _lMoney)
        {
            Money res = new Money();
            res.Amount = _lMoney.Amount - 0.01;
            res.Currency = _lMoney.Currency;
            return res;

        }
        public static bool operator >(Money _lMoney, Money _rMoney)
        {
            
            if (_lMoney.Currency != _rMoney.Currency)
            {
                Console.WriteLine("Impossible to compare money with different currencies");
                return false;
            }
            else
            {
                return _lMoney.Amount > _rMoney.Amount;

            }
        }
        public static bool operator <(Money _lMoney, Money _rMoney)
        {

            if (_lMoney.Currency != _rMoney.Currency)
            {
                Console.WriteLine("Impossible to compare money with different currencies");
                return false;
            }
            else
            {
                return _lMoney.Amount < _rMoney.Amount;

            }
        }
        //public static Money operator <(Money _lMoney, Money _rMoney)
        //{
        //    return _lMoney < _rMoney;
        //}

        public static bool operator ==(Money _lMoney, Money _rMoney)
        {
                return _lMoney.Equals(_rMoney);
        }
        public static bool operator !=(Money _lMoney, Money _rMoney)
        {
            return !_lMoney.Equals(_rMoney);
        }


        public override bool Equals(object obj)
        {
            return (obj is Money) && ((Money)obj).Amount == Amount;
        }
        public override string ToString()
        {
            //double res = Amount;
            
            return $"{String.Format("{0:0.00}", Amount)} {Currency}";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        
    }
}
