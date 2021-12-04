using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Вывести на экран 3 исходных строки не менее чем из 5 слов. Создать новую строку из двух на выбор,
            //   затем расположить их в алфавитном порядке. Ход программы отобразить пояснениями на экране.


            Console.WriteLine(@"Choose an option for executing the task. " +
                           "\n\t(1) - write your own strings (3 strings, 5 words minimum each); " +
                           "\n\t(2) - use preset strings");
            Console.Write("Your choice: ");
            int option1 = Convert.ToInt32(Console.ReadLine());
            bool presetFlag1 = false;
            switch (option1)
            {
                case 1:
                    {
                        Console.Write("Initial string 1: ");
                        string initStrUser1 = Console.ReadLine();
                        Console.Write("Initial string 2: ");
                        string initStrUser2 = Console.ReadLine();
                        Console.Write("Initial string 3: ");
                        string initStrUser3 = Console.ReadLine();
                        Task1(initStrUser1, initStrUser2, initStrUser3, presetFlag1 = false);
                        break;
                    }
                case 2:
                    {
                        string initStrPreset1 = "Lorem ipsum dolor sit amet";
                        string initStrPreset2 = "Consectetur adipiscing elit sed do";
                        string initStrPreset3 = "Eiusmod tempor incididunt ut labore";
                        Task1(initStrPreset1, initStrPreset2, initStrPreset3, presetFlag1 = true);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong option selected.");
                    break;

            }



            //2. При помощи метода Substring() извлечь из исходной строки 3 подстроки. Сравнить их по количетву
            //   элементов в каждой строке и рaсположить в порядке возрастания. Ход программы отобразить пояснениями на экране.

            Console.WriteLine(@"Choose an option for executing the task. " +
                           "\n\t(1) - write your own string (5 words minimum); " +
                           "\n\t(2) - use preset string");

            Console.Write("Your choice: ");
            int option2 = Convert.ToInt32(Console.ReadLine());
            bool presetFlag2 = false;
            switch (option2)
            {
                case 1:
                    Console.Write("Your string: ");
                    string initUserStr = Console.ReadLine();
                    Task2(initUserStr, presetFlag2);
                    break;
                case 2:
                    string initPresetStr = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
                    Task2(initPresetStr, presetFlag2 = true);
                    break;
                default:
                    Console.WriteLine("Wrong option selected");
                    break;
            }




            //3. При помощи метода Split() разобрать исходную строку на слова в виде массива строк.
            //   Затем объединить в новые строки каждую пару четных и нечетных строк и сравнить их
            //   на наличие одинаковых элементов. Ход программы отобразить пояснениями на экране.

            Console.Write("Write a string to run the code: ");
            string strT3 = Console.ReadLine();

            Task3(strT3);

            //4. Создать исходную строку при помощи класса StringBuilder из массива символьных значений,
            //   затем скопировать значение исходной строки в новую. Расположить в ней элементы в обратном
            //   порядке и вывести обе строки на экран. Ход программы отобразить пояснениями на экране.

            Console.WriteLine("Write a string you want to work with: ");
            string strT4 = Console.ReadLine();
            Task4(strT4);

        }




        static void Task1(string _str1, string _str2, string _str3, bool _flag)
        {
            Console.WriteLine();
            if (_flag)
            {
                Console.WriteLine($"Your preset strings: \n1: {_str1} \n2: {_str2} \n3: {_str3}");
            }

            Console.WriteLine();
            Console.WriteLine("Write numbers of strings you want to concatenate: ");
            Console.Write("String 1: ");
            int decision1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("String 2: ");
            int decision2 = Convert.ToInt32(Console.ReadLine());
            string resultStr = null;
                        
            if(decision1 == 1)
            {
                switch(decision2)
                {
                    case 2:
                        resultStr = string.Concat(string.Concat(_str1 + ' '), _str2);
                        break;
                    case 3:
                        resultStr = string.Concat(string.Concat(_str1 + ' '), _str3);
                        break;
                    default:
                        Console.WriteLine("Wrong strings were choosen.");
                        break;
                }
            }
            else if(decision1 == 2)
            {
                switch(decision2)
                {
                    case 1:
                        resultStr = string.Concat(string.Concat(_str2 + ' '), _str1);
                        break;
                    case 3:
                        resultStr = string.Concat(string.Concat(_str2 + ' '), _str3);
                        break;
                    default:
                        Console.WriteLine("Wrong strings were choosen.");
                        break;
                }
            }
            else if(decision1 == 3)
            {
                switch(decision2)
                {
                    case 1:
                        resultStr = string.Concat(string.Concat(_str3 + ' '), _str1);
                        break;
                    case 2:
                        resultStr = string.Concat(string.Concat(_str3 + ' '), _str2);
                        break;
                    default:
                        Console.WriteLine("Wrong strings were choosen.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong strings were choosen.");
            }
            Console.WriteLine();
            Console.WriteLine(resultStr);

            string[] resultStrArray = resultStr.Split(new char[] { ' ' });
            Array.Sort(resultStrArray);

            Console.WriteLine("\nArray after been sorted: ");
            PrintStringArr(resultStrArray);
            Console.WriteLine();
        }


        static void Task2(string _str, bool _flag)
        {
            Console.WriteLine();
            if (_flag)
            {
                Console.WriteLine($"Your preset string: {_str}");                 
            }
            
            Console.WriteLine("\nYou have to define 3 substrings by determining their sizes.");
            Console.Write("Size of substring 1: ");
            int subStrSize1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Size of substring 2: ");
            int subStrSize2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Size of substring 3: ");
            int subStrSize3 = Convert.ToInt32(Console.ReadLine());

            string[] strArray = new string[3];

            strArray[0] = _str.Substring(0, subStrSize1);
            strArray[1] = _str.Substring(subStrSize1, subStrSize2);
            strArray[2] = _str.Substring(subStrSize1+subStrSize2, subStrSize3);

            Console.WriteLine($"\nYour substrings: \n1: {strArray[0]}; \n2: {strArray[1]}; \n3: {strArray[2]};");
            Array.Sort(strArray, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine($"\nYour substrings after been sorted: ");
            Console.WriteLine($"\nYour substrings: \n1: {strArray[0]}; \n2: {strArray[1]}; \n3: {strArray[2]};");
        }


        static void Task3(string _str)
        {
            string[] strArr = _str.Split(new char[] { ' ' });

            string newStr1=null;
            string newStr2=null;            
            Console.WriteLine("Initial string: ");
            PrintStringArr(strArr);

            for(int i=0; i<strArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newStr1 += strArr[i];
                    newStr1 += ' ';
                }
                else
                {
                    newStr2 += strArr[i];
                    newStr2 += ' ';                    
                }
            }
            string[] newStrArr1 = newStr1.Split(new char[] { ' ' });
            string[] newStrArr2 = newStr2.Split(new char[] { ' ' });

            Console.WriteLine("\nResulting arrays of strings: ");
            PrintStringArr(newStrArr1);
            PrintStringArr(newStrArr2);

            bool containEqual = false;
                        
            for (int i=0; i < newStrArr1.Length-1; i++)
            {
                if (newStr2.Contains(newStrArr1[i]))
                {
                    containEqual = true;
                }               
            }

            if (containEqual)
            {
                Console.WriteLine("\nLines containing equivalent elements.");
            }
            else
            {
                Console.WriteLine("\nNo equivalent elements containing in lines.");
            }
        }


        static void Task4(string _str)
        {
            StringBuilder strBldr = new StringBuilder();
            
            foreach(char elem in _str)
            {
                strBldr.Append(elem);
            }

            StringBuilder reversedStrBldr = new StringBuilder();
            
            for (int i = strBldr.Length-1; i>-1; i--)
            {
                reversedStrBldr.Append(strBldr[i]);
            }

            string reversedString = reversedStrBldr.ToString();
            Console.WriteLine($"\nReversed: \n{reversedString}");
        }


        static void PrintStringArr(string[] _str)
        {
            foreach (string elem in _str)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
        }

        
    }
}
