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
        public Node<T> Left { get; set; } = null;
        public Node<T> Right { get; set; } = null;
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
            Console.Write(_offset);
            Console.WriteLine("(" + ToString());
            if (Right != null)
            {
                Right.DisplayNode(_offset + '\t');
            }
            else
            {
                Console.WriteLine(_offset + "(null)");
            }
            if (Left != null)
            {
                Left.DisplayNode(_offset + '\t');
            }
            else
            {
                Console.WriteLine(_offset + "(null)");
            }
            Console.WriteLine($"\n{_offset})");

        }

        //public void SearchNode(T _value, Node<T> _node)
        //{
        //    if (_node != null)
        //    {
        //        if (_value == _node.Value)
        //    }
        //}
        //public Node<T> Search(T _value)
        //{
        //    return this.SearchNode(_value, this.node);
        //}
        //public Node<T> SearchNode(T _value, Node<T> _node)
        //{
        //    if (_node != null)
        //    {
        //        if (_value == _node.Value)
        //        {
        //            return _node;   
        //        }
        //        if (_value < _node.Value)
        //        {
        //            return SearchNode(_value, _node.Left);
        //        }
        //        else
        //        {
        //            return SearchNode(_value, _node.Right);
        //        }
        //    }
        //    return null;
        //}

        //private Node Find(int value, Node parent)
        //{
        //    if (parent != null)
        //    {
        //        if (value == parent.Data) return parent;
        //        if (value < parent.Data)
        //            return Find(value, parent.LeftNode);
        //        else
        //            return Find(value, parent.RightNode);
        //    }

        //    return null;
        //}


        //public static bool operator <(Node<T> _node, int _num)
        //{
        //    if (_node.Value == typeof(System.Int32))
        //    {

        //    }
        //    return (int)_node.Value.CompareTo(_num); ;
        //}

        //public static bool operator >(Node<T> _node, int _num)
        //{
        //    return;
        //}

        public static bool operator==(Node<T> _node, T _num)
        {
            return _node.Equals(_num); 
        }
        public static bool operator!=(Node<T> _node, T _num)
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
