using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_CSharp
{
    internal class BinaryTree<T> where T : IComparable<T>
    {
        private Node<T> root = null;
        //private Node<T> Root { get; set; }
        public void AddNodeToTree(T _value)
        {
            if (root == null)
            {
                root = new Node<T>(_value);
            }
            else
            {
                root.AddNode(_value);   
            }
        }

        //public Node<T> FindNode (int _value)
        //{
        //    return this.FindNode(_value, this.root);
        //}

        //private Node<T> FindNode(T _value, Node<T> _node)
        //{
        //    if(_node !=null)
        //    {
        //        //if (_value == _node.Value)
        //        if (_node.Value.CompareTo(_value) == 0)
        //        {
        //            return _node;
        //        }
        //        if (_node.Value.CompareTo(_value) < 0)
        //        {
        //            return FindNode(_value, _node.Left);
        //        }
        //        else
        //        {
        //            return FindNode(_value, _node.Right);
        //        }
        //    }
        //    return null;
        //}


        public void DisplayTree()
        {
            if ( root != null)
            {
                root.DisplayNode("");
            }
            else
            {
                Console.WriteLine("Empty tree...");
            }
        }






    }
}
