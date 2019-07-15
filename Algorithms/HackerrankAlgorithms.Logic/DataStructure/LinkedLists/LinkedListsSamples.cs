﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankAlgorithms.Logic
{
    public static class LinkedListsSamples
    {

        public static List<SinglyLinkedListNode> BuildLinkedList(int[] arr)
        {
            List<SinglyLinkedListNode> linkedList = new List<SinglyLinkedListNode>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(arr[i]);
                if (i < arr.Length - 2)
                    node.next = new SinglyLinkedListNode(arr[i + 1]);
                linkedList.Add(node);
            }

            return linkedList;
        }


        public static int?[] printSinglyLinkedList(List<SinglyLinkedListNode> nodesList, int? headValue)
        {
            SinglyLinkedListNode head = null;

            foreach (var node in nodesList)
            {
                if (node.data == headValue)
                {
                    head = node;



                }
            }

            List<int?> reversedResult = new List<int?>();


            do
            {
                reversedResult.Add(head.data);
                head = head.next;

                if (head != null)
                    head.next = nodesList.Where(d => d.data == head.data).Select(n => n.next).FirstOrDefault();

            } while (head != null);


            return reversedResult.ToArray();
        }

        public static SinglyLinkedListNode insertNodeAtHead(int? headValue, int data)
        {

            SinglyLinkedListNode head = (headValue == null) ? null : new SinglyLinkedListNode(headValue);
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);

            if (head == null)
            {
                head = node;
            }

            else
            {
                node.next = head;
                head = node;
            }

            return head;
        }

        public static SinglyLinkedListNode deleteNode(SinglyLinkedListNode headNode, List<SinglyLinkedListNode> nodesList, int position)
        {
            int index = 0;

            SinglyLinkedListNode head = headNode;

            List<SinglyLinkedListNode> nodesListResult = new List<SinglyLinkedListNode>();
            nodesListResult.Add(head);

            while (head.next != null)
            {
                if (2 == index)
                {
                    SinglyLinkedListNode afterNext = head.next;
                   
                    if (afterNext != null)
                        head = nodesList.Where(d => d.data == head.data).Select(n => n.next).FirstOrDefault();
                    if (head!= null)
                        head.next = nodesList.Where(d => d.data == head.data).Select(n => n.next).FirstOrDefault();
                }
                else
                {

                    head = head.next;
                    if (head != null)
                        head.next = nodesList.Where(d => d.data == head.data).Select(n => n.next).FirstOrDefault();

                }
                index++;
                nodesListResult.Add(head);

            }

            return head;

        }

    }
}
