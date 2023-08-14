using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListEvent
    {
        public Node? First { get; set; }
        public void InsertFirst(int data)
        {
            // create the node
            Node node = new Node();
            // put data in new node
            node.Data = data;
            // Put the old node in next
            node.Next = First;
            // make the head the new node;
            First = node;
        }

        public Node DeleteFirst()
        {
            // Assign temp var
            Node temp = First;
            // Assign the new head
            First = First.Next;
            return temp;
        }
        public void DisplayList()
        {
            Console.WriteLine("Iterating through list....");
            Node current = First;
            while(current != null)
            {
                current.DisplayNode();
                // Iterating though a node 
                current = current.Next;
            }
        }
        public void InsertLast(int data)
        {
            Node current = First;
            while(current.Next != null)
            {
                current = current.Next;

            }
            Node node = new Node();
            node.Data = data;
            current.Next = node;
        }
    }
}
