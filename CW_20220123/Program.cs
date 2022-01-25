using System;

namespace CW_20220123
{
    class Program
    {
        //first delegate description
        public delegate double CalculatorDel(double a, double b);

        static void MakeOperaton(CalculatorDel operation)
        {
            Console.Write("Write down A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Write down B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Result: {operation(a, b)}");
        }

        //2nd wrapper-method, which will receive all results of each function held in delegate
        static void MakeComplexOperation(CalculatorDel operations)
        {
            Console.Write("Write down A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Write down B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //CalculatorDel[] operationsArr = (CalculatorDel[])operations.GetInvocationList();
            //operations.GetInvocationList();

            foreach(CalculatorDel operation in operations.GetInvocationList())
            {
                Console.WriteLine($"Result: {operation(a, b)}");
            }
        }
        static void Main()
        {
            //1. Delegate declaration
            // Delegate's type declaration (in class/in struct/in namespace)
            //2. Creataion delegate's instances
            CalculatorDel operation =Sum;
            //Console.WriteLine(operation(5, 15));
        
            //Console.WriteLine(operation(19, 15));
            //MakeOperaton(operation);
            //MakeOperaton(operation);
            operation += Sub;
            operation += Mul;


            //MakeOperaton(operation);
            MakeComplexOperation(operation); 
        }

        //opearations methods, which will be held in delegate
        static double Sum(double a, double b)
        {
            Console.WriteLine("Sum!");
            return a + b;
        }
        static double Sub(double a, double b)
        {
            Console.WriteLine("Sub!");
            return a - b;
        }
        static double Mul(double a, double b)
        {
            Console.WriteLine("Mul!");
            return a * b;
        }


    }
}