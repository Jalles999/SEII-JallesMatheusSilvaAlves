﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace video1.LinkedList
{
    internal class LinkedList
    {
        public Node Firt {  get; set; }   
        public void InsertFirst(int data)
        {
            //create the node
            Node newNode = new Node();
            //Put the data in the node
            newNode.Data = data;
            //put the old node in next
            newNode.Next = First;
            //make the first the new node 
            First = newNode;
        }
        public Node DeleteFirst()
        {
            //Assingn the temporary variable
            Node temp = First;
            // Assign the next dead 
            First = First.Next;
            return temp;
        }
        public void DisplayList ()
        {
            Console.WriteLine("Iterating thru list...");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }
        public void InsertLast(int data)
        {
            Node current = First; 
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}
