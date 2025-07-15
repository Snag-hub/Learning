using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAWithC_.DataStructures.Tree.Question
{
    public class TreeQuestions
    {
        public static void Inorder(TreeNode root)
        {
            if (root == null)
                return;

            Inorder(root.Left);         // Step 1: Left subtree
            Console.Write(root.Data + " ");  // Step 2: Root
            Inorder(root.Right);        // Step 3: Right subtree
        }

        public static void Preorder(TreeNode root)
        {
            if (root == null)
                return;

            Console.Write(root.Data + " ");  // Root
            Preorder(root.Left);             // Left
            Preorder(root.Right);            // Right
        }

        public static void Postorder(TreeNode root)
        {
            if (root == null)
                return;

            Postorder(root.Left);         // Left
            Postorder(root.Right);        // Right
            Console.Write(root.Data + " ");  // Root
        }
        public static int CountTreeNode(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                return 1 + CountTreeNode(root.Left) + CountTreeNode(root.Right);
            }
        }
        public static int Height(TreeNode root)
        {
            if (root == null)
                return 0;

            var LeftH = Height(root.Left);
            var RightH = Height(root.Right);

            return 1 + Math.Max(LeftH, RightH);
        }
    }

}