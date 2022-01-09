using System;

namespace HW12_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать класс Money, предназначенный для хранения денежной суммы(в гривнах и копейках). 
            // Для класса реализовать перегрузку операторов +(сложение денежных сумм), -(вычитание сумм), 
            // /(деление суммы на целое число), *(умножение суммы на целое число), ++(сумма увеличивается 
            // на 1 копейку), --(сумма уменьшается на 1 копейку), <, >, ==, !=.
          

            Money US = new Money("USD", 30);
            Money US2 = new Money("USD", 40);
            US++;
            Money RU = new Money("RUB", 500);
            Money RU2 = new Money("RUB", 20);
            RU--;
            Console.WriteLine(US);
            Console.WriteLine(RU);
            Console.WriteLine(RU*3);
            Console.WriteLine(US/3);
            Console.WriteLine(US == RU);
            Console.WriteLine(US != RU);
            Console.WriteLine(US + US2);
            Console.WriteLine(RU - RU2);
            Console.WriteLine(US + RU2);
            Console.WriteLine(US - RU2);
            Console.WriteLine(US > RU);
            Console.WriteLine(US > US2);
            Console.WriteLine(US < RU);
            Console.WriteLine(RU2 < RU);

        }
    }
}
