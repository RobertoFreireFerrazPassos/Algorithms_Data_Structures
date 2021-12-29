using System;
using System.Collections.Generic;

namespace Algorithms_Data_Structures
{
    public class LinkedList
    {
        public LinkedNode Head { get; private set; }

        public LinkedList() 
        {
            Head = null;
        }

        public void InsertFirst(object data)
        {
            var headCopy = Head;
            Head = new LinkedNode(data, Head);
        }

        public int Size()
        {
            int size = 0;
            if (Head != null)
            {
                size++;
                size = CountNext(Head, size);
            } 
            return size;
        }

        private int CountNext(LinkedNode node, int size)
        {
            if (node.Next != null)
            {
                size++;
                return CountNext(node.Next, size);
            } 
            return size;
        }
    }
}
