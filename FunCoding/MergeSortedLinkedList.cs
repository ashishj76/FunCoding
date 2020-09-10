using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class MergeSortedLinkedList
    {
        public class Node
        {
            public object data;
            public Node next;
            public Node(object data)
            {
                this.data = data;
            }
        }

        public class LinkedList
        {
            Node head;
            Node current;
            public Node Head
            { get { return head; } }

            public void Add(Node n)
            {
                if(head==null)
                {
                    head = n;
                    current = head;
                }
                else
                {
                    current.next = n;
                    current = current.next;
                }
            }

            public void printList()
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }

            public void Execute(Node first, Node second)
            {
                // We would be always adding nodes from the second list to the first one  
                // If second node head data is more than first one exchange it  
                if (Convert.ToInt32(first.next.data.ToString())
                        > Convert.ToInt32(second.data.ToString()))
                {
                    Node t = first;
                    first = second;
                    second = t;
                }
                head = first; //Assign head to first node  
                              //We need to assign head to first because first will continuosly be changing and so we want to store the beginning of list in head.  
                while ((first.next != null) && (second != null))
                {
                    if (Convert.ToInt32(first.next.data.ToString())
                        < Convert.ToInt32(second.data.ToString()))
                    {
                        first = first.next; //Iterate over the first node  
                    }
                    else
                    {
                        Node n = first.next;
                        Node t = second.next;
                        first.next = second;
                        second.next = n;
                        first = first.next;
                        second = t;
                    }
                }
                if (first.next == null) // Means there are still some elements in second  
                    first.next = second;
            }
        }
    }
}
