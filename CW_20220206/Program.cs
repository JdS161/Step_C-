using System;
using System.Collections.Generic;
using System.Linq;

namespace CW_20220206
{
    internal class Program
    {
        static void Imperative()
        {
            List<int> list = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(-50, 50));
            }
            foreach (int elem in list)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();


            List<int> list2 =new List<int>();

            Console.WriteLine();
            //iterational 
            foreach (int elem in list2)
            {
                if (elem > 0)
                {
                    list2.Add(elem);
                }
            }


            foreach (int elem in list2)
            {
                Console.Write($"{elem} ");
            }

        }

        static void Functional()
        {
            List<int> list = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(-50, 50));
            }
            list.ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();

            // direct LINQ query
            //List<int> list2 = (from elem in list where elem > 0 select elem).ToList();/*new List<int>();*/

            //LINQ using methods
            List<int> list2 = list.Where(elem => elem > 0).ToList();
            list2.ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();
            
        }

        static void Main(string[] args)
        {
            // For LAB:
            ////1. object money
            //Money money = new Money("RUR", 13890);

            ////2. delegate object
            //Money.MoneyConverDelegate del = null;

            //// adding to delegate anonimous method of convertion
            //del += delegate (double amount)
            //{
            //    return amount * 0.013;
            //};
            //money.MakeConverOperation(del);


            //del += delegate (double amount)
            //{
            //    return amount * 0.37;
            //};
            //money.MakeConverOperation(del);


            ////0.000007
            //del = (amount) => amount * 0.000007;

            //money.MakeConverOperation(del);


            //Imperative();
            //Functional();

            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(-50, 50));
            }

            //usual iteration through LIST
            foreach (int elem in list)
            {
                Console.WriteLine(elem);
            }

            //iteration through LIST using LINQ
            var res = from elem in list select elem;
            foreach (int  elem in res)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
