using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_CSharp
{
    internal class Node <T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        //private Node<T> left = null;    
        //private Node<T> right = null;

        public Node()
        {
            Value = default;
        }
        public Node(T _value)
        {
            Value = _value;
        }

        public void AddNode(T _value)
        {
            if (Value.CompareTo(_value) < 0)
            {
                if (Left == null)
                {
                    Left = new Node<T>(_value);
                }
                else
                {
                    Left.AddNode(_value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node<T>(_value);    
                }
                else
                {
                    Right.AddNode(_value);
                }
            }
        }

        //public void DeleteNode(T _value)
        //{

        //}

        public void DisplayNode(string _offset)
        {
            Console.WriteLine(_offset);
            Console.WriteLine("(" + ToString());
            if (Right != null)
            {
                Right.DisplayNode(_offset + '\t');
            }
            else
            {
                Console.WriteLine(_offset + "null");
            }
            if (Left != null)
            {
                Left.DisplayNode(_offset + '\t');
            }
            Console.WriteLine($"\n{_offset}");

        }

        //public void SearchNode(T _value)
        //{

        //}

        //public static bool operator <(Node<T> _node, int _num)
        //{
        //    //if(_node.Value == typeof(System.Int32))
        //    //{

        //    //}
        //    return (int)_node.Value.CompareTo(_num); ;
        //}
        //public static bool operator >(Node<T> _node, int _num)
        //{
        //    return;
        //}

        public static bool operator==(Node<T> _node, int _num)
        {
            return _node.Equals(_num); 
        }
        public static bool operator!=(Node<T> _node, int _num)
        {
            return !_node.Equals(_num);
        }
        public override string ToString()
        {
            return Value.ToString(); 
        }

        public override bool Equals(object obj)
        {
            //if(obj == typeof(System.Int32))
            //if(obj is Node<T>)
            //{
            //    Node<T> node = (Node<T>)obj;
            //    return Value == node.Value;
            //}
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }




    }
}
