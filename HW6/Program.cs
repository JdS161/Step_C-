using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //   Реализовать ведомость оценок студента по указанным предметам. Возможность вводить ведомость,
            //   читать средний балл для оценок по предмету, для оценок в целом. Реализовать поиск минимальной
            //   и максимальной оценки. Оформить хороший консольный интерфейс. Для реализации пользоваться
            //   одномерными и двумерными массивами.Оценки хранить либо в прямоугольном, либо в зубчатом массиве.
            //   Так же реализовать оценку аттестации студента(если средний балл > 2.5 и кол-во оценок > 2,
            //   то студента аттестован, иначе нет).


            Console.Write("Number of subjects: ");
            int numSubj = Convert.ToInt32(Console.ReadLine());

            string[] subjects = new string[numSubj];

            for (int i=0; i< numSubj; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                subjects[i] = Console.ReadLine();
            }
            
            int[][] marks = new int[numSubj][];
            for (int i=0; i<numSubj; i++)
            {
                marks[i] = new int[] { };
            }

            bool[] flags = new bool[numSubj];
            for (int  i = 0;  i <numSubj;  i++)
            {
                flags[i] = false;
            }

            Console.WriteLine("\nPress <Esc> for exit, <Enter> to continue");
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {


                Console.Write("\nWrite index of the subject, which marks you want to fill in:");
                int choosenSubj = Convert.ToInt32(Console.ReadLine());
                        
                Console.Write("\nHow many marks you want to fill: ");
                int numMarksAdded = Convert.ToInt32(Console.ReadLine());


                FillMarks(ref marks, subjects, ref choosenSubj, ref numMarksAdded, ref flags);
                PrintTable(ref marks, subjects, numSubj, ref flags);

                AverageTotal(ref marks, ref flags);
                Console.WriteLine("\nPress <Esc> for exit, <Enter> to continue");

            }



            //Console.Write("\nWrite index of the subject, which marks you want to fill in:");
            //int choosenSubj2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\nHow many marks you want to fill: ");
            //int numMarksAdded2 = Convert.ToInt32(Console.ReadLine());
            

            //FillMarks(ref marks, subjects, ref choosenSubj2, ref numMarksAdded2, ref flags);

            //Console.Write("\nWrite index of the subject, which marks you want to fill in:");
            //int choosenSubj3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\nHow many marks you want to fill: ");
            //int numMarksAdded3 = Convert.ToInt32(Console.ReadLine());


            //FillMarks(ref marks, subjects, ref choosenSubj3, ref numMarksAdded3, ref flags);

            //PrintTable(ref marks, subjects, numSubj);


             








        }
        
        static void AverageDiscipline(ref int[][] _marks, int _choosenSubj, ref bool[] _flags)
        {
            if(_flags[_choosenSubj] == false)
            {
                Console.Write($" {0:##.0}");
            }
            else
            {
                Console.Write($"{_marks[_choosenSubj].Average():##.0}");

            }

        }
        static void AverageTotal(ref int[][] _marks, ref bool[] _flags)
        {
            double result = 0.0;
            for (int i = 0; i <_marks.Length ; i++)
            {
                if(_flags[i]==false)
                {
                    result += 0.0;
                }
                else
                {
                    result += _marks[i].Average();
                }
            }
            Console.WriteLine($"Total average: {result / _marks.Length:##.0}");
        }
        static void MinMark(ref int[][] _marks, int _choosenSubj, ref bool[] _flags)
        {
            int minMark = 5;
            if(_flags[_choosenSubj] == false)
            {
                Console.Write("N/a");
            }
            else
            {
                for (int i = 0; i < _marks[_choosenSubj].Length; i++)
                {
                    if(_marks[_choosenSubj][i] < minMark)
                    {
                        minMark = _marks[_choosenSubj][i];
                    }
                }
                Console.Write($" {minMark} ");
            }

        }

        static void MaxMark()
        {

        }

        static void Performance()
        {

        }
        static void PrintTable(ref int[][] _marks, string[] _subjects, int _numSubj, ref bool[] _flags)
        {
            System.Console.Clear();
           
            char pad = '.';
            Console.WriteLine();
            for (int i = 0; i < _numSubj; i++)
            {
                Console.Write($" {i + 1} {_subjects[i].PadRight(15, pad)} | ");
                AverageDiscipline(ref _marks, i, ref _flags);
                Console.Write(" | ");
                MinMark(ref _marks, i, ref _flags);
                Console.Write(" | ");
                PrintMarks(_marks, i);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void FillMarks(ref int[][] _marks,string[] _subjects, ref int _choosenSubj, ref int _numMarksAdded, ref bool[] _flags)
        {
            if (_flags[_choosenSubj - 1] == false)
            {
                Array.Resize(ref _marks[_choosenSubj - 1], _numMarksAdded);

                for (int i = 0; i < _numMarksAdded; i++)
                {
                    Console.Write($"{_subjects[_choosenSubj - 1]}'s mark {i + 1}: ");
                    _marks[_choosenSubj - 1][i] = Convert.ToInt32(Console.ReadLine());

                }
                _flags[_choosenSubj - 1] = true;
            }
            else
            {
                int len = _marks[_choosenSubj - 1].Length;
                Array.Resize(ref _marks[_choosenSubj - 1], len + _numMarksAdded);

                for (int i = len; i < len+_numMarksAdded; i++)
                {
                    Console.Write($"{_subjects[_choosenSubj - 1]}'s mark {i + 1}: ");
                    _marks[_choosenSubj - 1][i] = Convert.ToInt32(Console.ReadLine());

                }
                _flags[_choosenSubj - 1] = true;
            }

        }
      
        static void PrintMarks(int[][] arr, int _row)
        {
            foreach(int item in arr[_row])
            {
                Console.Write($"{item} ");
            }
        }
    
    }
}
