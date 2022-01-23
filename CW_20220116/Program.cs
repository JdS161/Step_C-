using System;
using System.Collections;
using System.Collections.Generic;

namespace CW_20220116
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();

            //list.Add(10);
            //list.Add("Hello");
            //list.Add(new Foo());
            //list.Add(DateTime.Now);


            //foreach (var elem in list)
            //{
            //    Console.WriteLine(elem);
            //}

            // 1. List <T> - same as std::vector<T>

            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add("2".GetHashCode());

            //foreach (int elem in list)
            //{
            //    Console.WriteLine(elem);
            //}

            //List<string> list2 = new List<string>();
            //list2.Add("first");
            //list2.Add("second");
            //list2.Add("third");

            //foreach (string elem in list2)
            //{
            //    Console.WriteLine(elem);
            //}

            //2. Dictionary - same as std::map

            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //dict.Add("first", 1);
            //dict["second"] = 2;

            //Console.WriteLine(dict["first"]);
            //Console.WriteLine(dict["second"]);
            BinaryTree<int> tree = new BinaryTree<int>();

            Random random = new Random();
            for (int i=0; i< 10; i++)
            {
                tree.Add(random.Next(0,50));
            }

            tree.DisplayTree();

        }
    }
}
