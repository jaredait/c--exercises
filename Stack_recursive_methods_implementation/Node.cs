using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_recursive_methods_implementation
{
    class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        // Constructor
        public Node(object data)
        {
            Data = data;
        }
    }
}
