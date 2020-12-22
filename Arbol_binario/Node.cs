using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_tree
{
    class Node
    {
        // Properties
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public object Key { get; set; }

        // Constructor
        public Node(object item)
        {
            Key = item;
            LeftChild = null;
            RightChild = null;
        }
    }
}
