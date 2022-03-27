using System;

namespace HW16_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ход работы.

            //3.Реализуйте конструктор класса, необходимые свойства, переопределите
            //  метод ToString.

            //4.Добавьте в класс описание делегата:
            //public double MoneyConvertDelegate(double value).

            //5. Добавьте в класс метод, принимающий в качестве параметра делегат типа,
            //   который указан выше.Данный метод должен делать вызов переданного
            //   делегата(через GetinvocationsList).

            //6. В Main создайте объект класса Money и объект делегата
            //   MoneyConvertDelegate.

            //7. Добавьте в созданный делегат анонимный метод для конвертации долларов
            //   в рубли, выполнив:
            //          del += delegate (double amount)
            //          { 
            //            Console.WriteLine($”{amount}$ = {amount* k} руб”);
            //       } где k – отношение курса одной валюты к другой.

            //8. Аналогичным образом добавьте еще 3 конвертера из долларов в
            //произвольную валюту, используя анонимные методы.

            //9. Протестируйте, выполнив вызов метода с передачей делегата в
            //качестве параметра.

            //Бонусное задание (по желанию):
            //10.Добавьте в созданный ранее делегат лямбду для конвертации
            //долларов в золото.

            //11. Еще раз все протестировать. 



            //1. object money
            Money money = new Money("RUB", 13890);

            //2. delegate object
            Money.MoneyConverDelegate del = null;

            // adding to delegate anonimous method of convertion

            //RUB -> USD
            del += delegate (double amount)
            {
                return amount * 0.013;
            };
            //money.MakeConvertOperation(del);

            //RUB -> UAH (rate = 0.37)
            del += delegate (double amount)
            {
                return amount * 0.37;
            };
            //money.MakeConvertOperation(del);


            //RUB -> GOLD (rate = 0.000227)
            del = (amount) => Math.Round(amount * 0.000227, 2);
            //money.MakeConvertOperation(del);
            Console.WriteLine("\r GOLD");

            //RUB -> SILVER (rate = 0.01775)
            del = (amount) => Math.Round(amount * 0.01775, 2);
            money.MakeConvertOperation(del);






        }
    }
}
