using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using DataStructuresAndAlgorithms.Logic;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Test
{
    [TestFixture]
    public class BinarySearchTreeTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 4, 1, 10)]
        public void Test_CheckBST(int[] arr, int root, int min, int max)
        {
            #region preperation

            List<Node> nodes = new List<Node>();
            for (int i = 0; i < arr.Length; i++)
            {
                Node node = new Node();
                nodes.Add(new Node() { data = arr[i] });

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

            #endregion
            BinarySearchTree bst = new BinarySearchTree();

            var result = bst.CheckBST(nodes[3]);

            Assert.AreEqual(result, true);
            
        }
    }
}
