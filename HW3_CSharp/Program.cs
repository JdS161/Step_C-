using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Реализовать программу решения квадратного уравнения. Пользователь вводит коэффициенты a, b, c уравнения ax2 +bx + c = 0, 
            //  программа выводит решение данного уравнения.
            //Console.Write("Write down A=");
            //double firstNum = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Write down B=");
            //double secondNum = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Write down C=");
            //double thirdNum = Convert.ToDouble(Console.ReadLine());

            //Task1(firstNum, secondNum, thirdNum);

            //2.Реализовать программу разложения числа на простые множители. 
            
            //Console.Write("Write a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            
            //Task2(number);




            //3.Усовершенствовать программу проверки простого числа с урока следующим образом: теперь программа должна определять, является 
            //  ли число совершенным(число равно сумме своих делителей кроме него самого, т.е. 6 = 1 + 2 + 3 = 1 * 2 * 3).Запустить алгоритм 
            //  в цикле и указать, какие совершенные числа вы смогли отыскать.
            Console.Write("Write a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Task3(number2);

        }

        static void Task1(double firstNum, double secondNum, double thirdNum)
        {
            double discriminant = Math.Pow(secondNum, 2) - (4*firstNum*thirdNum);
            double root1;
            double root2;

            if (discriminant < 0)
            {
                Console.WriteLine($"Discriminant D ={discriminant} is LESS than 0 => NO ROOTS");
            }
            else if (discriminant ==0)
            {
                root1 = -(secondNum / (2 * firstNum));
                Console.WriteLine($"Discriminant D = {discriminant} is EQUALS to 0 => 1 ROOT x1 = {root1}");
            }
            else
            {
                root1 = (-secondNum + Math.Sqrt(discriminant)) / 2 * firstNum;
                root2 = (-secondNum - Math.Sqrt(discriminant)) / 2 * firstNum;
                Console.WriteLine($"Discriminant D = {discriminant}, is GREATER than 0 => ROOT1 x1 = {root1}, ROOT2 x2 = {root2}");
            }

        }
        static void Task2(int _num)
        {
            int size = 1;
            int maxValue = _num;
            int[] arrayOfPrimeDividers = new int[size];
            int pos = 0;
            while (_num != 1)
            {
                for (int i=2; i<maxValue; i++)
                {
                    if (isPrime(i))
                    {
                        if (_num % i == 0)
                        {
                            Array.Resize(ref arrayOfPrimeDividers, size);                    
                            arrayOfPrimeDividers[pos] = i;
                            pos++;
                            _num /= i;
                            break;
                        }
                    }
                }
                size++;
            }

            for (int i=0; i< arrayOfPrimeDividers.Length -1; i++)
            {
                Console.Write($"{arrayOfPrimeDividers[i]} * ");
            }
            Console.Write($"{arrayOfPrimeDividers[arrayOfPrimeDividers.Length-1]}");
            Console.WriteLine();

        }

        static void Task3(int _num)
        {
            int size = 1;
            int sumElements = 0;
            int[] arrayOfPrimeDividers = new int[size];
            int pos = 0;
            
            for (int i = 1; i < _num; i++)
            {       
                if (_num % i == 0)
                {
                    Array.Resize(ref arrayOfPrimeDividers, size);
                    arrayOfPrimeDividers[pos] = i;
                    pos++;
                    sumElements += i;
                    
                }
                size++;        
            }

            for (int i = 0; i < pos - 1; i++)
            {
                Console.Write($"{arrayOfPrimeDividers[i]} * ");
            }
        
            Console.Write($"{arrayOfPrimeDividers[pos - 1]}");
            Console.WriteLine();

            Console.WriteLine($"sum = {sumElements}");

        }

        static bool isPrime(int _num)
        {
            for(int i=2; i<_num; i++)
            {
                if (_num%i ==0)
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
                                   
