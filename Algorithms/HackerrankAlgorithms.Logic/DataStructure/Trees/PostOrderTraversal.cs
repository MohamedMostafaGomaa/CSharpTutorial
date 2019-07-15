using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic.DataStructure.Trees
{
    public class PostOrderTraversal
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

            PostOrder(root, ref output);
        }

        // Left subtree -> Right subtree -> Root
        static void PostOrder(Node root, ref string output)
        {

            if (root == null)
            {
                return;
            }

            PostOrder(root.left, ref output);           
            PostOrder(root.right, ref output);
            output += (root.data + " ");

        }

       
    }
}
