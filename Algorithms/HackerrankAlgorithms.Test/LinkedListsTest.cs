using System;
using NUnit.Framework;
using HackerrankAlgorithms.Logic;
using System.Collections.Generic;


namespace HackerrankAlgorithms.Test
{
    [TestFixture]
    public class LinkedListsTest
    {

        [Test]
        [TestCase(new int[] { 383, 484, 392, 975, 321 }, new int[] { 321, 975, 392, 484, 383 })]
        public void insertNodeAtHeadTest(int[] llistArr, int[] llistArrExpected)
        {
            List<SinglyLinkedListNode> llist = new List<SinglyLinkedListNode>();

            int? head = null;
            List<int?> resultList = new List<int?>();

            for (int i = 0; i < llistArr.Length; i++)
            {
                SinglyLinkedListNode llist_head = LinkedListsSamples.insertNodeAtHead(head, llistArr[i]);

                head = llist_head.data;
                llist.Add(llist_head);
            }

            int?[] resultArr = LinkedListsSamples.printSinglyLinkedList(llist, head);

            Assert.AreEqual(resultArr, llistArrExpected);
        }


        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        public void insertNodeAtTailTest(int[] llistArr, int[] llistArrExpected)
        {
           
            SinglyLinkedListNode head = null;
            List<int?> resultList = new List<int?>();

            for (int i = 0; i < llistArr.Length; i++)
            {
                SinglyLinkedListNode llist_head = LinkedListsSamples.insertNodeAtTail(head, llistArr[i]);

                head = llist_head;
               
            }

            int?[] resultArr = LinkedListsSamples.printSinglyLinkedList(head);

            Assert.AreEqual(resultArr, llistArrExpected);
        }


        [Test]
        [TestCase(new int[] { 20, 6, 2, 19, 7, 4, 15, 9 }, new int[] { 20, 6, 2, 7, 4, 15, 9 }, 3)]
        public void DeleteNodeTest(int[] llistArr, int[] llistArrExpected, int position)
        {
            List<SinglyLinkedListNode> linkdedList = LinkedListsSamples.BuildLinkedList(llistArr);

            List<SinglyLinkedListNode> linkdedListResult = new List<SinglyLinkedListNode>();

            SinglyLinkedListNode linkdeListNode = LinkedListsSamples.deleteNode(linkdedList[0], linkdedList, position);


            int?[] resultArr = LinkedListsSamples.printSinglyLinkedList(linkdedList, linkdedList[0].data);

            Assert.AreEqual(resultArr, llistArrExpected);
        }


        [Test]
        [TestCase(new int[] { 20, 6, 2, 19, 7, 4, 15, 9 }, new int[] { 20, 6, 2, 7, 4, 15, 9 }, 3)]
        public void DeleteNodeTest2(int[] llistArr, int[] llistArrExpected, int position)
        {
            SinglyLinkedListNode linkdedList = LinkedListsSamples.BuildLinkedList2(llistArr);

            List<SinglyLinkedListNode> linkdedListResult = new List<SinglyLinkedListNode>();

            SinglyLinkedListNode linkdeListNode = LinkedListsSamples.deleteNode(linkdedList, position);


            //int?[] resultArr = LinkedListsSamples.printSinglyLinkedList(linkdeListNode, ta);

            //Assert.AreEqual(resultArr, llistArrExpected);
        }
    }
}
