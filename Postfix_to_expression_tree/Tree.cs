using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Postfix_to_expression_tree
{
    class Tree
    {
        // Properties
        public Node Root { set; get; }

        // Constructor
        public Tree()
        {
            Root = null;
        }

        // Methods
        public void SetNode(string expression)
        {
            Stack stackLetters = new Stack();
            Stack<Node> stackNodes = new Stack<Node>();
            Root = SetNode(expression, Root, stackLetters, stackNodes);
        }
        /*
        // AB*C+
        private void SetNode(string expression, Node temp, Stack stack)
        {
            // if the expresion is empty
            if (expression == string.Empty)
                return;

            if (char.IsLetter(expression[0]))
            {
                stack.Push(Convert.ToString(expression[0]));
                SetNode(expression.Substring(1, expression.Length - 1), temp, stack);
            }

            if (char.IsSymbol(expression[0]))
            {
                temp = new Node(Convert.ToString(expression[0]));
                object auxLeft = stack.Peek();
                
                Node left = new Node(stack.Pop());

                Node Right = new Node(stack.Pop());
                temp.LeftChild = left;
                temp.RightChild = Right;
                stack.Push(temp);
                SetNode(expression.Substring(1, expression.Length - 1), temp, stack);
            }

            if(char.IsSymbol(expression[0]), temp, stackLetters, stackNodes)
                {
                temp = new Node(Convert.ToString(expression[0]));
                if (stackNodes.Count > 0)
                    Node left = stackNodes.Pop();
                else
                    Node left = new Node(stackLetters.Pop());

                if (stackLetters.Count > 0)
                    Node right = new Node(stackLetters.Pop());
            }
        }
        */

        private Node SetNode(string expression, Node temp, Stack stackLetters, Stack<Node> stackNodes)
        {
            // if the expresion is empty
            if (expression == string.Empty)
                return stackNodes.Pop();

            if (char.IsLetter(expression[0]))
            {
                stackLetters.Push(Convert.ToString(expression[0]));
                return SetNode(expression.Substring(1, expression.Length - 1), temp, stackLetters, stackNodes);
            }

            if (IsOperator(expression[0]))
            {
                temp = new Node(Convert.ToString(expression[0]));
                Node right = null;
                Node left = null;

                if (stackLetters.Count > 0)
                    right = new Node(Convert.ToString(stackLetters.Pop()));
                else
                    right = stackNodes.Pop();

                if
                (stackLetters.Count > 0)
                    left = new Node(Convert.ToString(stackLetters.Pop()));
                else
                    left = stackNodes.Pop();

                temp.LeftChild = left;
                temp.RightChild = right;
            }
            stackNodes.Push(temp);
            return SetNode(expression[1..], temp, stackLetters, stackNodes);
        }

        public bool IsOperator(char op)
        {
            if (op == '+' || op == '-' || op == '*' || op == '/')
                return true;
            return false;
        }

        // Prints the tree by console
        public void Print()
        {
            Print(Root, 4);
        }
        private void Print(Node p, int padding)
        {
            if(p != null)
            {
                if (p.RightChild != null)
                    Print(p.RightChild, padding + 4);
                if (padding > 0)
                    Console.Write(" ".PadLeft(padding));
                if(p.RightChild != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.Key.ToString() + "\n ");
                if(p.LeftChild != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.LeftChild, padding + 4);
                }
            }
        }

        // Postorder traversal of the tree. Prints the expression postfix notation
        public void PrintPostfix()
        {
            Console.WriteLine("Postfix: {0}", PrintPostfix("", Root));
        }
        private string PrintPostfix(string expression, Node temp)
        {
            if (temp.LeftChild != null)
                expression = PrintPostfix(expression, temp.LeftChild);
            if (temp.RightChild != null)
                expression = PrintPostfix(expression, temp.RightChild);

            return expression + temp.Key;
        }

        // Preorder traversal of the tree. Prints the expression's prefix notation (Prefix notation)
        public void PrintPrefix()
        {
            Console.WriteLine("Prefix: {0}", PrintPrefix("", Root));
        }
        private string PrintPrefix(string expression, Node temp)
        {
            expression += temp.Key;

            if (temp.LeftChild != null)
                expression = PrintPrefix(expression, temp.LeftChild);
            if (temp.RightChild != null)
                expression = PrintPrefix(expression, temp.RightChild);

            return expression;
        }

        // Inorder traversal of the tree. Prints the expression's infix notation
        public void PrintInfix()
        {
            Console.WriteLine("Infix: {0}", PrintInfix("", Root));
        }
        private string PrintInfix(string expression, Node temp)
        {
            if (temp.LeftChild != null)
                expression = PrintInfix(expression, temp.LeftChild);

            expression += temp.Key;

            if (temp.RightChild != null)
                expression = PrintInfix(expression, temp.RightChild);

            return expression;
        }

    }
}
