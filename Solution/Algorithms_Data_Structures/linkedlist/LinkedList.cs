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
    }
}