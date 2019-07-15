using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public static class TreesSamples
    {
        //Height of a Binary Tree
        //https://www.hackerrank.com/challenges/tree-height-of-a-binary-tree/problem

        public static int StartGetTreeHeight(int[] arr)
        {

            int index = 0;
            // set the root
            Node root = new Node(arr[0]);

            while (index++ < arr.Length - 1)
            {
                int data = arr[index];
                root = Node.insert(root, data);
            }

            return GetTreeHeight(root);

        }


        static int GetTreeHeight(Node root)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if (root.left != null)
            {
                leftHeight = 1 + GetTreeHeight(root.left);
            }

            if (root.right != null)
            {
                rightHeight = 1 + GetTreeHeight(root.right);
            }

            return (leftHeight > rightHeight) ? leftHeight : rightHeight;
        }




       
    }
}
