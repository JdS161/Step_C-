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

            Console.Write("\nWrite index of the subject, which marks you want to fill in:");
            int choosenSubj = Convert.ToInt32(Console.ReadLine());
                        
            Console.Write("\nHow many marks you want to fill: ");
            int numMarksAdded = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref marks[choosenSubj-1], numMarksAdded);

            for (int i=0; i< numMarksAdded; i++)
            {
                Console.Write($"{subjects[choosenSubj-1]}'s mark {i + 1}: ");
                marks[choosenSubj][i] = Convert.ToInt32(Console.ReadLine());
            }


            System.Console.Clear();

            char pad = '.';

            for (int i = 0; i < numSubj; i++)
            {
                Console.Write($"\t{i + 1} {subjects[i].PadRight(15, pad)} | ");
                PrintMarks(marks, i);
                Console.WriteLine();
            }





            

















        }
    
    static void FillMarks()
        {

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
