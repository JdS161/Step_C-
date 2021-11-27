using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace HW3_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Реализовать программу решения квадратного уравнения. Пользователь вводит коэффициенты a, b, c уравнения ax2 +bx + c = 0, 
            //  программа выводит решение данного уравнения.

            Console.Write("Write down A=");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write down B=");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write down C=");
            double thirdNum = Convert.ToDouble(Console.ReadLine());

            Task1(firstNum, secondNum, thirdNum);

            //2.Реализовать программу разложения числа на простые множители. 

            Console.Write("Write a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task2(number);


            //3.Усовершенствовать программу проверки простого числа с урока следующим образом: теперь программа должна определять, является 
            //  ли число совершенным(число равно сумме своих делителей кроме него самого, т.е. 6 = 1 + 2 + 3 = 1 * 2 * 3).Запустить алгоритм 
            //  в цикле и указать, какие совершенные числа вы смогли отыскать.

            Console.WriteLine("Perfect numbers (ulong format): ");

            var sw = new Stopwatch();           //создем объект класса Stopwatch для подсчета времени выполнения программы
            sw.Start();                         //запускаем таймер
            Task3();
            sw.Stop();                          //Останавливаем таймер
            TimeSpan ts = sw.Elapsed;           //инициализируем экземпляр структуры TimeSpan для последующего читабельного вывода времени

            Console.WriteLine($"Time Spent to find available Perfect Numbers: {ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds / 10}");
        }

        static void Task1(double firstNum, double secondNum, double thirdNum)
        {
            double discriminant = Math.Pow(secondNum, 2) - (4 * firstNum * thirdNum);
            double root1;
            double root2;

            if (discriminant < 0)
            {
                Console.WriteLine($"Discriminant D ={discriminant} is LESS than 0 => NO ROOTS");
            }
            else if (discriminant == 0)
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
            int size = 1;                                                       //размер массива
            int maxValue = _num;                                                //сохраняем число в отдельную переменную для итерирования в цикле
            int[] arrayOfPrimeDividers = new int[size];                         //создаем массив на 1 элемент 
            int pos = 0;                                                        //позиция элемента в массиве
            if (_num < 2)                                                       //проверяем, можно ли число разложить на простые множители
            {
                Console.WriteLine("This number can't be factorized for prime dividers");
                
            }
            else if (IsPrime(_num))                                             //если введенное число изначально простое - вносим его в массив и выводим
            {
                arrayOfPrimeDividers[pos] = _num;
                PrintArray(arrayOfPrimeDividers);                               //Вывод массива
            }
            else
            {
                while (_num != 1)                                               //проверяем, можно ли еще делить заданное число
                {
                    for (int i = 2; i < maxValue; i++)                          //проверяем все числа от 2 до заданного на принадлежность к простым множителям
                    {
                        if (IsPrime(i))                                         //если число простое - проверяем, делит ли оно без остатка наше число
                        {
                            if (_num % i == 0)                                  //если число делится без отатка - заносим это число в массив
                            {
                                Array.Resize(ref arrayOfPrimeDividers, size);   //изменяем размер массива (увеличиваем на 1)
                                arrayOfPrimeDividers[pos] = i;                  //записываем число в массив с определенной позицией
                                pos++;                                          //инкрементируем позиию
                                _num /= i;                                      //делим число на его простой множитель
                                break;
                            }
                        }
                    }
                    size++;                                                     //инкрементируем размер массива
                }
                PrintArray(arrayOfPrimeDividers);                               //Вывод массива
            }            
        }

        static void Task3()
        {
            int count = 0;                              
            for ( int i=1; count< 8; i++)               //Дальше 8го числа искать совершенное число не имеет смысла, т.к. не позволяет диапазон ulong числа
            {
                //Согласно теоремы Эвклида-Эйлера, совершенное число n имеет следующую форму: n=(2^(k−1)) *((2^k)−1) 
                ulong testNum = ((ulong)Math.Pow(2, (i - 1))) * (((ulong)Math.Pow(2, i)) - 1);
                if (IsPerfectNumber(testNum))           //Проверяем число на принадлежность к совершенным числам
                {
                    count++;                            //В случае положительного результата - увеличиваем счетчик
                    Console.WriteLine(testNum);         //Выводим число в консоль
                }
            }
        }
            

        static bool IsPerfectNumber(ulong _num)         //функция для проверки числа на принадлежность к совершенным числам
        {
            if (_num < 2)                               //Если число меньше 1 - выходим из цикла
                return false;   
            ulong sumOfElements = 1;                    //Т.к. в любом случае 1 - один из слагаемых делителей - сразу добавим его в конечную сумму
            ulong sqroot = (ulong)Math.Sqrt(_num);      //Если Y делит X, то и X/Y также делит X. Следовательно далее мы сможем добавлять сразу два делителя,
                                                        //двигаясь по числу "навстручу друг к другу", и чтобы не проходить 2 раза по циклу в обоих направлениях - 
                                                        //необходимо остановиться в середине числа. Такой "остановкой" будет корень этого числа.
            
            for (ulong i=2; i<=sqroot; i++)             //Проходимся циклом от 2х до корня
            {
                if (_num%i == 0)                        //Проверяем, делится ли число на итератор
                {
                    sumOfElements += i + _num / i;      //Добавлем к сумме итератор и число, деленное на итератор
                    if (sumOfElements > _num)           //Если сумма превышает изначальное число - выходим из функции с отрицательным результатом
                        return false;
                }
            }
            return sumOfElements == _num;               //Если сумма равнв изначальному числу - выходим из функции с положительным результатом

        }

       

        static bool IsPrime(int _num)       //функция проверки числа на простоту
        {
            for(int i=2; i<_num; i++)       //от 2 до переданного числа, проверяем, является ли оно простым
            {
                if (_num%i ==0)             //проверяем, делится ли число без остатка на 0
                {
                    return false;           //если делится - число не является простым
                }
            }
            return true;                    //если не делится - число простое
        }

        static void PrintArray(int[]_arr)               //функция вывода массива в консоль
        {
            for (int i = 0; i < _arr.Length - 1; i++)
            {
                Console.Write($"{_arr[i]} * ");
            }
            Console.Write($"{_arr[_arr.Length - 1]}");
            Console.WriteLine();
        }
    }
}
                                   
