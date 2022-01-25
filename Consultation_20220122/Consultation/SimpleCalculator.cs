using System;

    
namespace Consultation_20220122
{
    static class SimpleCalculator
    {
    static char ReadOperands(out double a, out double b)
    {
        Console.WriteLine();
        try
        {
            Console.Write("Write operand A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write operand B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write operation sign: ");
            //Console.WriteLine();
            return Console.ReadKey().KeyChar;            
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Some error occured...{ex.Message}");
            Console.Write("Would you like to try again? (+/-)");
            if (Console.ReadKey().KeyChar == '+')
            {
                return ReadOperands(out a, out b);
            }            
            else 
            {
                a=b=0;
                return 'q';
            }
        }
    }

    static public void Run()
    {
        bool isEnd = false;
        while (!isEnd)
        {
            //1

            try
            {
                double a, b;
                char op = ReadOperands(out a, out b);
                Console.WriteLine();

                switch(op)
                {
                    case '+':
                        Console.WriteLine($"{a} + {b} = {a+b}");
                        break;
                    case '-':
                        Console.WriteLine($"{a} - {b} = {a-b}");
                        break;
                    case '*':
                        Console.WriteLine($"{a} * {b} = {a*b}");
                        break;
                    case '/':
                        Console.WriteLine($"{a} / {b} = {a/b}");
                        break;
                    case '%':
                        Console.WriteLine($"{a} % {b} = {a%b}");
                        break;
                    case 'q':
                        Console.WriteLine("Bye...");
                        isEnd = true;
                        break;
                    default:
                        Console.WriteLine("Invaid operation");
                        break;
                }                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Something went wrong... {ex.Message}");                
            }
            finally
            {
                Console.WriteLine("Next Round!");
            }
        }
    }
}
    
}
