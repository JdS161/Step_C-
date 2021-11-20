using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //int a = 0;
            //Console.WriteLine(a);
            //string a_str = a.ToString();
            //Console.WriteLine(a_str);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(a_str.Length);


            //double foo = 1;
            //foo /= 3;
            //Console.WriteLine("foo = {0}", foo);
            //foo *= 3;
            //Console.WriteLine("foo = {0}", foo);


            //decimal foo = 1;
            //foo /= 3;
            //Console.WriteLine("foo = {0}", foo);
            //foo *= 3;
            //Console.WriteLine("foo = {0}", foo);

            //char symb = (char)48;
            //Console.WriteLine(symb);
            //Console.WriteLine(sizeof(char));
            //Console.WriteLine("Русский язык выводится без подключения setlocale");


            //string str_1 = null;
            //string str_2 = "";
            //int? a = null;
            //int b = a ?? 3;
            //Console.WriteLine(b);


            ////ax + b = 0

            //double a, b;
            //Console.Write("Write down a: ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("Write down b: ");
            //b = Convert.ToDouble(Console.ReadLine());
            //double x = -b / a;
            //Console.WriteLine(x);  

            //Console.WriteLine("x = {0}; a = {1}, b = {2}", x, a, b);
            //Console.WriteLine($"x = {x}; a = {a}, b = {b}");


            //int a = 0b1010;
            //Console.WriteLine(a);




            //double a, b, x;
            //Console.Write("A = ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("B = ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("X = ");
            //x = Convert.ToDouble(Console.ReadLine());

            //if (a > b)
            //{
            //    double temp = a;
            //    a = b;
            //    b = temp;
            //}
            //if (x>a && x <b)
            //{
            //    Console.WriteLine($"Number {x} is in range ({a}, {b})");
            //}
            //else if (x ==a || x == b)
            //{
            //        Console.WriteLine($"Number {x} is on the border of the range ({a}, {b})");
            //}
            //else
            //{
            //        Console.WriteLine($"Number {x} is out of the range ({a}, {b})");
            //}

            //int num;
            //num = Convert.ToInt32(Console.ReadLine());
            //bool isSimple = true;
            //for (int i = 2; i < num && isSimple; i++)
            //{
            //    if (num% i == 0)
            //    {
            //        isSimple = false;
            //    }
            //}

            //if (isSimple)
            //{
            //    Console.WriteLine($"Number {num} is simple");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {num} is not simple");
            //}
            ////isSimple ? Console.WriteLine($"Number {num} is simple") : Console.WriteLine($"Number {num} is not simple"); // TODO: Check this line









            //---------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------ARRAYS--------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------------------------------

            //int[] arr = new int[10];
            //for (int i=0; i< arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}


            //Console.WriteLine();

            //foreach (int elem in arr)
            //    Console.Write($"{elem} ");

            //Console.WriteLine();

            //int[] marks = new int[8];

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.Write("Input a mark");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ////average:
            //double average = marks.Average();
            //Console.WriteLine($"Average = {average}");

            ////marks values counter
            //int[] countMarks = new int[marks.Max() + 1];
            //for (int i=0; i < countMarks.Length; i++)
            //{
            //    countMarks[i] = marks.Count(elem => elem == i);
            //}

            //for (int  i = 0; i < countMarks.Length; i++)                            //      TODO: UNDERSTAND THIS!!!
            //{                                                                       //          LINES 145-155
            //    Console.WriteLine($"Number of marks {i} = {countMarks[i]}");
            //}



            //int[] arr_1 = new int[] { 1, 2, 3 };
            //int[] arr_2 = arr_1;
            //arr_2[0] = 0;
            //Console.WriteLine(arr_1[0]);

            ////DEEP COPY
            //arr_1 = new int[] { -1, -2, -3 };
            //arr_1.CopyTo(arr_2, 0);
            //arr_2[0] = 0;
            //Console.WriteLine(arr_1[0]);


            ////rectangular 2-dimensional array
            //int rows = 3, cols = 5;
            //double[,] matrix = new double [rows,cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for ( int j=0; j< cols; j++)
            //    {
            //        matrix[i, j] = i * j ;
            //    }
            //} 

            //for (int i = 0; i < rows; i++)
            //{
            //    for ( int j=0; j< cols; j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //    Console.WriteLine();

            //foreach(double elem in matrix)
            //{
            //        Console.Write($"{elem} ");
            //}
            //    Console.WriteLine();

            //triangle array
            int[][] trArr = new int[3][]; // 3 empty rows created here
            trArr[0] = new int[1];
            trArr[1] = new int[2];
            trArr[2] = new int[3];


            for (int i = 0; i < trArr.Length; i++)
            {
                for (int j = 0; j < trArr[i].Length; j++)
                {
                    trArr[i][j] = i - j - 10;
                    Console.Write($"{trArr[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            foreach ( int[] str in trArr)
            {
                foreach(int elem in str)
                {
                    Console.Write($"{elem} ");
                }
                Console.WriteLine();
            }



        }



    }
}
