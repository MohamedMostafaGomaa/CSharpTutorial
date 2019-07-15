using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Logic
{

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

    public class BinarySearchTree
    {
        bool CheckBST(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }
            if (root.data < min || root.data > max)
            {
                return false;
            }

            return (CheckBST(root.left, min, root.data - 1) && CheckBST(root.right, root.data + 1, max));
        }

        public bool CheckBST(Node root )
        {
            int min = 1;
            int max = 10;
            return CheckBST(root, min, max);
        }
    }
}
