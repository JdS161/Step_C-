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


            Console.Write("ROWS = ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("COLUMNS = ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Task1(rows, cols);


            //2.Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные
            //  (0 считать положительным).

            //3.Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число
            //  встречается в массиве.

            //4.В двумерном массиве порядка M на N поменяйте местами заданные столбцы.


        }



        static void Task1(int _rows, int _cols)
        {
            int[,] array = new int[_rows, _cols];
            Random rand = new Random();
            for(int i=0; i<_rows; i++)
            {
                for(int j = 0; j< _cols; j++)
                {
                    array[i, j] = rand.Next(0, 9);
                }
            }

            PrintArray(array, _rows, _cols);

            for(int i=0; i< _rows; i++)
            {
                for (int j=0; j< _cols-1; j++)
                {
                    if (array[i,j] == 0 && array[i, j + 1] != 0)
                    {
                        array[i, j] = array[i, j+1];
                        array[i, j+1] = 0;
                    }

                }
            }



            Console.WriteLine();
            Console.WriteLine("Modified array:");
            PrintArray(array, _rows, _cols);


        }


        static void Task2()
        {

        }
        static void Task3()
        {

        }
        static void Task4()
        {

        }

        static void PrintArray(int[,] _arr, int _rows, int _cols)
        {
            switch (_arr.Rank)
            {
                case 1:
                   // Console.WriteLine("1-dimensional array:");
                    for(int i =0; i<1; i++)
                    {
                        for (int j = 0; j < _cols; j++)
                        {
                            Console.Write($"{_arr[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    //Console.WriteLine($"{_arr.Rank}-dimensional array [{_rows},{_cols}]:");

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
    }
}
