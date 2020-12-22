using System;
using System.Collections.Generic;
using System.Text;

namespace Postfix_to_expression_tree
{
    class Node
    {
        // Properties
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public string Key { get; set; }

        // Constructor
        public Node(string key)
        {
            Key = key;
            LeftChild = null;
            RightChild = null;
        }
    }
}
