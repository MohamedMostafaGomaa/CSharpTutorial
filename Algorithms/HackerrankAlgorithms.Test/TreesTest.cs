using System;
using NUnit.Framework;
using HackerrankAlgorithms.Logic;
using System.Collections.Generic;


namespace HackerrankAlgorithms.Test
{
    [TestFixture]
    public class TreesTest
    {
        [Test]
        [TestCase(new int[] { 3, 2, 4, 5 }, 6, new int[] { 3, 2, 5, 4, 6 })]
        public void SelfBalancingTreeTest(int[] arrInput, int input, int[] arrExpected)
        {
            List<Node> nodes = new List<Node>();
            foreach (var num in arrInput)
            {
                var res = SelfBalancingTree.insert(new Node(-1), num);
            }
        }
    }
}
