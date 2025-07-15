using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSAWithC_.DataStructures.Tree.Question;

namespace DSAWithC_.DataStructures.Tree
{
    public class Trees
    {
        public static TreeNode BuildSampleTree()
        {
            TreeNode root = new TreeNode(10);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(15);
            root.Left.Left = new TreeNode(2);
            root.Left.Right = new TreeNode(7);
            root.Right.Left = new TreeNode(12);

            return root;
        }

        public void RunAll()
        {
            var root = BuildSampleTree();

            TreeQuestions.Inorder(root);
            Console.WriteLine();
            TreeQuestions.Preorder(root);
            Console.WriteLine();
            TreeQuestions.Postorder(root);
            Console.WriteLine();
            int cnt = TreeQuestions.CountTreeNode(root);
            Console.WriteLine($"Count: {cnt}");
            int he = TreeQuestions.Height(root);
            Console.WriteLine($"Height: {he}");

        }
    }
}