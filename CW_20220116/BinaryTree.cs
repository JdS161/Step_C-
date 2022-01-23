using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20220116
{
    // Generic-class
    class BinaryTree<T> where T : IComparable<T>
    {
        private Node<T> root = null;

        public void Add(T _value)
        {
            if (root == null)
                root = new Node<T>(_value);
            else
                root.Add(_value);
        }

        public void DisplayTree()
        {
            if (root != null)
                root.DisplayNode("");
            else
                Console.WriteLine("Empty tree...");
        }



    }
}
