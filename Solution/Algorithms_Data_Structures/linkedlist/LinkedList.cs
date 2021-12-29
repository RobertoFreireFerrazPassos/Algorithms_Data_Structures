﻿namespace Algorithms_Data_Structures
{
    public class LinkedList
    {
        private LinkedNode Head;

        public LinkedList() 
        {
            Head = null;
        }

        public void InsertFirst(object data)
        {
            Head = new LinkedNode(data, Head);
        }

        public int Size()
        {
            int size = 0;
            LinkedNode currentNode = Head;

            while (currentNode != null)
            {
                size++;
                currentNode = currentNode.Next;
            } 
            return size;
        }

        public LinkedNode GetFirst()
        {
            return Head;
        }

        public LinkedNode GetLast()
        {
            LinkedNode currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Next == null) return currentNode;
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        public void Clear()
        {
            Head = null;
        }

        public void RemoveFirst()
        {
            Head = Head != null ? Head.Next : null;
        }

        public void RemoveLast()
        {
            if (Head == null) return;

            if (Head.Next == null)
            {
                Head = null;
                return;
            }

            var previousNode = Head;
            var currentNode = Head.Next;

            while (currentNode.Next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            previousNode.Next = null;
        }

        public void InsertLast(object data)
        {
            var lastNode = GetLast();
            var newNode = new LinkedNode(data);
            if (lastNode != null)
            {
                lastNode.Next = newNode;
            }
            else 
            {
                Head = newNode;
            }
        }

        public LinkedNode GetAt(int index)
        {
            int counter = 0;
            LinkedNode currentNode = Head;

            while (currentNode != null)
            {
                if (index == counter) return currentNode;
                counter++;
                currentNode = currentNode.Next;
            }
            return null;
        }
    }
}