using System;

namespace HW14_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree <int> tree = new BinaryTree<int>();

            Random random = new Random();
            for (int i=0; i<10; i++)
            {
                tree.AddNodeToTree(random.Next(0, 30));
            }

            tree.DisplayTree();
        }
    }
}
