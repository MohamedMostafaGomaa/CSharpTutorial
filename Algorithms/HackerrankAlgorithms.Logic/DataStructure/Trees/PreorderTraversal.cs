using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    // https://www.hackerrank.com/challenges/tree-preorder-traversal/problem
    public static class PreorderTraversal
    {

        public static int[] run(int input, int[] intArrr)
        {

            bool isOrdered = false;
            int index = 0;
            int length = intArrr.Length - 1;
            bool isFound = false;

            while (isOrdered == false)
            {

                if (intArrr[index] == input)
                {
                    isFound = true;
                    if (index == 0)
                    {
                        if (intArrr[index] > intArrr[index + 1])
                        {
                            int temp = intArrr[index + 1];
                            intArrr[index + 1] = intArrr[index];
                            intArrr[index] = temp;
                            index++;
                        }
                        else
                        {
                            isOrdered = true;
                        }
                    }
                    else if (index == length)
                    {
                        if (intArrr[index] < intArrr[index - 1])
                        {
                            int temp = intArrr[index - 1];
                            intArrr[index - 1] = intArrr[index];
                            intArrr[index] = temp;
                            index--;
                        }
                        else
                        {
                            isOrdered = true;
                        }
                    }
                    else
                    {
                        if (intArrr[index] > intArrr[index + 1])
                        {
                            int temp = intArrr[index + 1];
                            intArrr[index + 1] = intArrr[index];
                            intArrr[index] = temp;
                            index++;
                        }
                        else if (intArrr[index] < intArrr[index - 1])
                        {
                            int temp = intArrr[index - 1];
                            intArrr[index - 1] = intArrr[index];
                            intArrr[index] = temp;
                            index--;
                        }

                    }

                }
                else
                {
                    if (!isFound)
                        index++;

                }

                if (index == 0 || index == length)
                    isOrdered = true;


            }

            return intArrr;
        }

        private static void swap(ref int[] arr, int index1, int index2)
        {

        }

        //List<Node> nodes = buildNodes(intArrr);
        //Node temp = null;

        //for (int i = 0; i < nodes.Count; i++)
        //{
        //    if (input == nodes[i].data)
        //    {
        //        if (nodes[i].data < nodes[i].left.data)
        //        {
        //            temp = null;
        //            temp = new Node(nodes[i].left.data);
        //            temp.left = nodes[i].left;
        //            temp.right = nodes[i].right;


        //            nodes[i].data = nodes[i].data 



        //        }
        //    }
        //}



        static List<Node> buildNodes(int[] arr)
        {
            List<Node> nodes = new List<Node>();
            for (int i = 0; i < arr.Length; i++)
            {
                Node node = new Node(arr[i]);
                nodes.Add(node);

            }

            for (int j = 0; j < nodes.Count; j++)
            {
                if (j == 0)
                {
                    nodes[j].left = null;
                    nodes[j].right = nodes[j + 1];
                }
                else if (j >= nodes.Count - 1)
                {
                    nodes[j].left = nodes[j - 1];
                    nodes[j].right = null;
                }
                else
                {
                    nodes[j].left = nodes[j - 1];
                    nodes[j].right = nodes[j + 1];
                }

            }
            return nodes;
        }

        // Root -> Left subtree -> Right subtree
        static void preOrder(Node root, ref string output)
        {
            if (root == null)
            {
                return;
            }

            output += (root.data + " ");
            preOrder(root.left, ref output);
            preOrder(root.right, ref output);

        }

       


        public static void StartOrder(int[] arr, ref string output)
        {

            int index = 0;
            Node root = new Node(arr[0]);
            while (index++ < arr.Length - 1)
            {
                int data = arr[index];
                root = Node.insert(root, data);
            }

            preOrder(root, ref output);
        }



    }

   



}
