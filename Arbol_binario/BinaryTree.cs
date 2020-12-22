using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_tree
{
    class BinaryTree
    {
        // Properties
        public Node Root { get; set; }

        // Constructors
        public BinaryTree(object item)
        {
            Root.Key = item;
        }
        public BinaryTree()
        {
            Root = null;
        }

        // Methods

        // Insert. Places the node in the first occurrence of a null node. Uses a stack to keep the trace of the node's references (USELESS)
        public void Insert(object key)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);
            Node temp = Root;

            if (Root == null)
            {
                Root = new Node(key);
                queue.Dequeue();
            }

            while (queue.Count != 0)
            {
                temp = queue.Dequeue();
                if (temp.LeftChild == null)
                {
                    temp.LeftChild = new Node(key);
                    break;
                }
                else
                    queue.Enqueue(temp.LeftChild);
                if (temp.RightChild == null)
                {
                    temp.RightChild = new Node(key);
                    break;
                }
                else
                    queue.Enqueue(temp.RightChild);

                queue.Dequeue();
            }
        }

        // SETNODE (overloaded method). Places the nodes so that a binary search could be used to search for a value
        public void SetNode(int key)
        {
            Root = SetNode(key, Root);
        }
        private Node SetNode(int key, Node temp)
        {
            // Base case
            if (temp == null)
                temp = new Node(key);
            // Recursive case
            else
            {
                if (key < (int)temp.Key)
                    temp.LeftChild = SetNode(key, temp.LeftChild);
                else
                    temp.RightChild = SetNode(key, temp.RightChild);
            }
            return temp;
        }

        public void SetNode(string key)
        {
            Root = SetNode(key.ToLower(), Root);
        }
        private Node SetNode(string key, Node temp)
        {
            if (temp == null)
                temp = new Node(key);
            else
            {
                if (AFirstThanB(key, (string)temp.Key))
                    temp.LeftChild = SetNode(key, temp.LeftChild);
                else
                    temp.RightChild = SetNode(key, temp.RightChild);
            }
            return temp;
        }

        // PRINT. (overloaded) Prints the tree using recursion
        public void Print()
        {
            Print(Root, 4);
        }
        private void Print(Node p, int padding)
        {
            if (p != null)
            {
                if (p.RightChild != null)
                    Print(p.RightChild, padding + 4);

                if (padding > 0)
                    Console.Write(" ".PadLeft(padding));

                if (p.RightChild != null) 
                { 
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.Key.ToString() + "\n ");
                if (p.LeftChild != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.LeftChild, padding + 4);
                }
            }
        }

        // CONTAINS (overloaded). Returns true if the tree contains the value of the argument (first occurrence)
        public bool Contains(int num)
        {
            return Contains(num, Root);
        }
        private bool Contains(int num, Node temp)
        {
            // Base cases
            if (temp == null)
                return false;
            if (num == (int) temp.Key)
                return true;
            // Recursive cases
            if (num < (int)temp.Key)
                return Contains(num, temp.LeftChild);
            else
                return Contains(num, temp.RightChild);
        }

        public bool Contains(string str)
        {
            return Contains(str.ToLower(), Root);
        }
        private bool Contains(string str, Node temp)
        {
            if (temp == null)
                return false;
            if (str == (string)temp.Key)
                return true;

            if (AFirstThanB(str, (string)temp.Key))
                return Contains(str, temp.LeftChild);
            else
                return Contains(str, temp.RightChild);
        }

        // OCURRENCES (overloaded). Returns the number of occurrences of the argument in the tree
        public int Occurrences(int num)
        {
            return Ocurrences(num, Root, 0);
        }
        private int Ocurrences(int num, Node temp, int count)
        {
            // Base case
            if (temp == null)
                return count;
            // Recursive case
            if (num == (int)temp.Key)
                count++;
            if (num < (int)temp.Key)
                return Ocurrences(num, temp.LeftChild, count);
            else
                return Ocurrences(num, temp.RightChild, count);
        }

        public int Occurrences(string str)
        {
            return Occurrences(str.ToLower(), Root, 0);
        }
        private int Occurrences(string str, Node temp, int count)
        {
            if (temp == null)
                return count;
            if (str == (string)temp.Key)
                count++;

            if (AFirstThanB(str, (string)temp.Key))
                return Occurrences(str, temp.LeftChild, count);
            else
                return Occurrences(str, temp.RightChild, count);
        }



        // AFirstThanB. Returns true if the string a is first than the string b alphabetically
        static bool AFirstThanB(string a, string b)
        {
            // Base cases
            if (a.Length <= 0 || b.Length <= 0)
                return false;
            if (a[0] < b[0])
                return true;
            if (a[0] > b[0])
                return false;
            // Recursive cases
            return AFirstThanB(a[1..], b[1..]);
        }
    }
}

