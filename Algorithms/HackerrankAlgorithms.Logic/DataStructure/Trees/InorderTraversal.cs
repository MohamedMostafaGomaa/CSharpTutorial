using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    // https://www.hackerrank.com/challenges/tree-inorder-traversal/problem
    public class InorderTraversal
    {
        public static void StartOrder(int[] arr, ref string output)
        {

            int index = 0;
            Node root = new Node(arr[0]);
            while (index++ < arr.Length - 1)
            {
                int data = arr[index];
                root = Node.insert(root, data);
            }

            inOrder(root, ref output);
        }

        // Left subtree -> Root -> Right subtree
        static void inOrder(Node root, ref string output)
        {

            if (root == null)
            {
                return;
            }

            inOrder(root.left, ref output);
            output += (root.data + " ");
            inOrder(root.right, ref output);

        }

        
    }


}
