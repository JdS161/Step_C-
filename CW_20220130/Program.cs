using System;

namespace CW_20220130
{
    internal class Program

    {

        //private delegate int TestDel();

        //private static TestDel test = null;

        private delegate double CalculatorDel(double a, double b);

        static void Main(string[] args)
        {
            //test += First;
            //test += Second;
            //test += Third;

            ////Console.WriteLine(test());
            //Console.WriteLine(test?.Invoke());

            //foreach (TestDel item in test.GetInvocationList())
            //{
            //    Console.WriteLine(item());
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (TestDel item in test.GetInvocationList())
            //{
            //    Console.WriteLine(item?.Invoke());
            //}


            CalculatorDel calculator = null;

            //1. Addition of the SUM method using ANONIMOUS method
            calculator += delegate (double a, double b)
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
                return a + b;
            };

            //2. Addition of the 
            calculator += Sub;


            // 3. Using Lambdas
            calculator += ( a,  b) => a + b;
            
            calculator += ( a,  b) =>
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
                return a * b;
            };



            // Print out
            calculator?.Invoke(1,2);






        }

        static double Sub(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
            return a - b;
        }


        //static int First()
        //{
        //    Console.WriteLine("First!");
        //    return 0;
        //} 
        //static int Second()
        //{
        //    Console.WriteLine("Second!");
        //    return 1;
        //} static int Third()
        //{
        //    Console.WriteLine("Third!");
        //    return 2;
        //}


    }
}
