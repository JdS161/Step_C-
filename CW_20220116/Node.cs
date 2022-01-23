using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20220116
{
    class Node<T> where T : IComparable<T>
    {
        //field of common type, which stores a value of a node of a tree
        public T Value { get; set; }

        //links in a tree
        private Node<T> left = null;
        private Node<T> right = null;
        

        //default constructor
        public Node()
        {
            Value = default;
        }

        public Node(T _value)
        {
            Value = _value;
        }

        public void Add(T _value)
        {
            if (Value.CompareTo(_value) < 0)
            {

                if (left == null)
                    left = new Node<T>(_value);
                else
                    left.Add(_value);
            }
            else
            {
                if (right == null)
                    right = new Node<T>(_value);
                else
                    right.Add(_value);
            }
        }

        public void DisplayNode(string _offset)
        {
            Console.Write(_offset);
            Console.WriteLine("(" + ToString());
            if (right != null)
                right.DisplayNode(_offset + '\t');
            else
            {
                Console.WriteLine(_offset + "null");
            }
            if (left != null)
                left.DisplayNode(_offset + '\t');
            else
            {
                Console.WriteLine(_offset + "null");
            }
            Console.WriteLine($"\n{_offset}") ;
        }

        public override string ToString()
        {
            return Value.ToString();
        }


    }
}
