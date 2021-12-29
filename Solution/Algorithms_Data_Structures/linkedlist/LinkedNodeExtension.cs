using System;

namespace Algorithms_Data_Structures
{
    public static class LinkedNodeExtension
    {
        public static void forEach(this LinkedList linkedList, Func<LinkedNode, object> lambda)
        {
            LinkedNode currentNode = linkedList.GetFirst();

            while (currentNode != null)
            {
                currentNode.Data = lambda(currentNode);
                if (currentNode.Next == null) return;
                currentNode = currentNode.Next;
            }
            return;
        }
    }
}
