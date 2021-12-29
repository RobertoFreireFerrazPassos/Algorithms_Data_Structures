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
            
    }

    public class LinkedNode
    {
        public object Data;
        public LinkedNode Next;

        public LinkedNode(object data, LinkedNode next)
        {
            Data = data;
            Next = next;
        }
    }
}
