using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //1.Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1.

            Console.WriteLine("Write dimension of array:");
            Console.Write("ROWS = ");
            int rows1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("COLUMNS = ");
            int cols1 = Convert.ToInt32(Console.ReadLine());

            Task1(rows1, cols1);


            //2.Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные
            //  (0 считать положительным).
            Console.WriteLine("Write dimension of array:");
            Console.Write("ROWS = ");
            int rows2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("COLUMNS = ");
            int cols2 = Convert.ToInt32(Console.ReadLine());

            Task2(rows2, cols2);

            //3.Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число
            //  встречается в массиве.
            Console.WriteLine("Write dimension of array:");
            Console.Write("ROWS = ");
            int rows3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("COLUMNS = ");
            int cols3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("NUMBER to search = ");
            int num = Convert.ToInt32(Console.ReadLine());

            Task3(rows3, cols3, num);

            //4.В двумерном массиве порядка M на N поменяйте местами заданные столбцы.
            Console.WriteLine("Write dimension of array:");
            Console.Write("ROWS = ");
            int rows4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("COLUMNS = ");
            int cols4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("COLUMN 1 to swap = ");
            int swapCol1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("COLUMN 2 to swap = ");
            int swapCol2 = Convert.ToInt32(Console.ReadLine());

            Task4(rows4, cols4, swapCol1 - 1, swapCol2 - 1);


        }



        static void Task1(int _rows, int _cols)
        {
            int[,] array = InitRandomArray(_rows, _cols, 0, 9);             //Инициализуирем массив и заполняем его случайными числами посредством вспомогательной функции
            PrintArray(array, _rows, _cols);                                //Выводим массив в консоль

            //Смешаем все нулевые элементы в конец массива
            for (int i=0; i< _rows; i++)                                    //Итерируясь по элементам массива находим первый 0-й элемент
            {
                int rowLength = _cols-1;
                for (int j=0; j< rowLength; j++)
                {
                    if (array[i, j] == 0)           
                    {
                        for (int k = j; k < rowLength - 1; k++)         
                        {
                            Swap(ref array[i, k], ref array[i, k + 1]);     //И производим обмен элементов от найденного ноля до конца массива -1
                        }
                        array[i, rowLength] = 0;                            //Последнему элементу в массиве присваиваем 0
                        rowLength--;                                        //Уменьшаем размер массива для итерирования, чтобы не проверять лишние ноли
                        j--;
                    }                  
                }
            }

            //Все обнаруженные ранее нулевые элементы массива приравниваем к -1
            //for(int i=0; i<_rows;i++)
            //{
            //    for(int j=0; j<_cols;j++)
            //    {
            //        if (array[i,j]==0)
            //        {
            //            array[i, j] = -1;
            //        }
            //    }
            //}
            Console.WriteLine();
            Console.WriteLine("Modified array:");                           //Выводим измененный массив в консоль                  
            PrintArray(array, _rows, _cols);
        }



        static void Task2(int _rows, int _cols)
        {
            int[,] array = InitRandomArray(_rows, _cols, -10, 20);          //Инициализуирем массив и заполняем его случайными числами посредством вспомогательной функции 
            PrintArray(array, _rows, _cols);                                //Выводим массив в консоль

            //Производим сортировку массива ПУЗЫРЬКОМ
            bool swapped = true;                                            

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols - 1; j++)
                    {
                        if (array[i, j] > array[i, j + 1])
                        {
                            Swap(ref array[i, j], ref array[i, j + 1]);
                            swapped = true;
                        }
                    }
                }
            }

                
            Console.WriteLine();
            Console.WriteLine("Modified array:");                           //Выводим измененный массив в консоль
            PrintArray(array, _rows, _cols);
        }
        static void Task3(int _rows, int _cols, int _num)
        {
            int[,] array = InitRandomArray(_rows, _cols, 0, 15);        //Инициализуирем массив и заполняем его случайными числами посредством вспомогательной функции
            PrintArray(array, _rows, _cols);                            //Выводим массив в консоль

            int counter = 0;                                            //Вводим переменную счетчика для подсчета количетва искомых чисел
            for (int i=0; i< _rows; i++)                                //Итерируемся по массиву
            {
                for (int j=0; j< _cols; j++)
                {
                    if (array[i,j] == _num)                             //Если значение элемента массива равно искомому значению - 
                    {
                        counter++;                                      //инкрементируем счетчик
                    }
                }
            }

            Console.WriteLine($"NUMBER {_num} contains {counter} times in array.");

        }
        static void Task4(int _rows, int _cols, int _swapCol1, int _swapCol2)
        {
            int[,] array = InitRandomArray(_rows, _cols, 0, 9);                 //Инициализуирем массив и заполняем его случайными числами посредством вспомогательной функции
            PrintArray(array, _rows, _cols);                                    //Выводим массив в консоль

            for(int i=0; i< _rows; i++)
            {
                for ( int j=0; j< _cols; j++)
                {
                    Swap(ref array[i, _swapCol1], ref array[i, _swapCol2]);     //Производим замену элементов массива посредством вспомогательной функции
                    break;                                                      //Прерываем выполнение цикла после первой замены, чтобы не получилось обратной замены
                }
            }
            Console.WriteLine();                                            
            Console.WriteLine("Modified array:");                               //Выводим изененный массив на экран   
            PrintArray(array, _rows, _cols);
        }


        //Вспомогательная функция инициализации массива случайными числами
        static int [,] InitRandomArray(int _rows, int _cols, int _valueMin, int _valueMax)
        {
            int[,] array = new int[_rows, _cols];                       //Инициализируем массив необходимого размера 
            Random rand = new Random();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    array[i, j] = rand.Next(_valueMin, _valueMax);      //Инициализируем массив случайными числами в необходимом диапазоне от _valueMin до _valueMax
                }
            }
            return array;
        }

        //Вспомогательная функция вывода массива в консоль
        static void PrintArray(int[,] _arr, int _rows, int _cols)
        {
            switch (_arr.Rank)                                      //Проверяем размерность массива
            {
                case 1:                                             //Выводим одномерный массив поэлементно
                    for(int i =0; i<1; i++)
                    {
                        for (int j = 0; j < _cols; j++)
                        {
                            Console.Write($"{_arr[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:                                             //Выводим двумерный массив поэлементно      
                    for (int i=0; i<_rows; i++)
                    {
                        for (int j = 0; j < _cols; j++)
                        {
                            Console.Write($"{_arr[i,j]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    break;

            }
        }

        //Вспомогательная функция обмена значений
        static void Swap(ref int _firstNum, ref int _secondNum)
        {
            int temp = _firstNum;       //Производим замену элементов с помощью 3го дополнительного числа
            _firstNum = _secondNum;
            _secondNum = temp;
        }

    }
}
