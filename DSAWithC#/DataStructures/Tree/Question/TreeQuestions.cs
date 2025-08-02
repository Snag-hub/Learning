using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public static int CountLeaf(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            // Leaf node condition
            if (root.Left == null && root.Right == null)
            {
                return 1;
            }

            // Recurse on both sides
            return CountLeaf(root.Left) + CountLeaf(root.Right);
        }

        public static int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + CountNodes(root.Left) + CountNodes(root.Right);
        }

        public static int TreeNodeSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return root.Data + TreeNodeSum(root.Left) + TreeNodeSum(root.Right);
        }

        public static bool AreIdentical(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }
            if (root1 == null || root2 == null)
            {
                return false;
            }

            return AreIdentical(root1.Left, root2.Left) && AreIdentical(root1.Right, root2.Right);
        }
    }

}
