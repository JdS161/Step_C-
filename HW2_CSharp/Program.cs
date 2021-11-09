using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW2_CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
//          1.	Пользователь вводит число секунд.Перевести секунды в часы, минуты, секунды.
            int inputSeconds;
            Console.Write("Enter seconds to conversion: ");
            inputSeconds = int.Parse(Console.ReadLine());
            Task1(inputSeconds);
            Console.WriteLine();

//          2.	Пользователь вводит длину окружности L.Найти радиус такой окружности.
            double circumference;
            Console.Write("Enter circumference L: ");
            circumference = double.Parse(Console.ReadLine());
            Task2(circumference);
            Console.WriteLine();

//          3.	Пользователь вводит трехзначное целое число.Найти сумму цифр данного числа.Например, введено 123. Программа выводит сумму цифр = 6.
            int number;
            Console.Write("Enter 3-digit number: ");
            number = int.Parse(Console.ReadLine());
            Task3(number);
            Console.WriteLine();
        }

        static void Task1(int inputSeconds)
        {
            int hours = inputSeconds / 3600;
            int minutes = (inputSeconds - (hours * 3600)) / 60;
            int seconds = inputSeconds - (hours * 3600) - (minutes * 60);

            Console.WriteLine($"In {inputSeconds} seconds: {hours} hours, {minutes} minutes and {seconds} seconds");
        }

        static void Task2(double circumference)
        {
            double radius = circumference / (2 * Math.PI);

            Console.WriteLine($"If L = {circumference}, radius = {radius}");
        }

        static void Task3 (int number)
        {
            if (number > 999)
            {
                Console.WriteLine("Given number is too large.");
            }
            else
            {
                int first = number / 100;
                int second = (number - (first * 100)) / 10;
                int third = number % 10;

                Console.WriteLine($"Sum of numbers = {first + second + third}");
            }
        }
    }
}
