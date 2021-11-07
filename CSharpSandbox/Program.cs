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

            //char symb = (char) 48;
            //Console.WriteLine(symb);
            //Console.WriteLine(sizeof(char));
            //Console.WriteLine("Русский язык выводится без подключения setlocale");


            //string str_1 = null;
            //string str_2 = "";
            //int? a = null;
            //int b = a ?? 3;
            //Console.WriteLine(b);


            //ax + b = 0

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine(x);

            Console.WriteLine("x = {0}; a = {1}, b = {2}", x, a, b);
            Console.WriteLine($"x = {x}; a = {a}, b = {b}");
        }
    }
}
