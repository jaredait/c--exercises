using System;

namespace Binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.SetNode("J");
            tree.SetNode("f");
            tree.SetNode("m");
            tree.SetNode("A");
            tree.SetNode("h");
            tree.SetNode("l");
            tree.SetNode("j");
            tree.SetNode("jar");

            Console.WriteLine("Contains: {0}", tree.Occurrences("a"));
            tree.Print();
            Console.ReadKey();
        }   
    }
}
