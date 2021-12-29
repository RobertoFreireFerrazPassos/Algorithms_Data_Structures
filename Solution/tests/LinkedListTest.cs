using Algorithms_Data_Structures;
using Xunit;

namespace tests
{
    public class LinkedListTest
    {
        [Fact]
        public void MustAppendsNodeToTheStartOfTheList()
        {
            var list = new LinkedList();
            list.InsertFirst(1);
            Assert.Equal(1,list.Head.Data);
            list.InsertFirst(2);
            Assert.Equal(2,list.Head.Data);
            Assert.Equal(1, list.Head.Next.Data);
        }

        [Fact]
        public void MustReturnSizeOfList()
        {
            var list = new LinkedList();
            Assert.Equal(0, list.Size());
            list.InsertFirst(1);
            list.InsertFirst(1);
            list.InsertFirst(1);
            list.InsertFirst(1);
            Assert.Equal(4, list.Size());
        }

        [Fact]
        public void MustGetFirstNodeOfList()
        {
            var list = new LinkedList();
            Assert.Null(list.GetFirst()?.Data);
            list.InsertFirst(13);
            Assert.Equal(13, list.GetFirst()?.Data);
            list.InsertFirst(7);
            Assert.Equal(7, list.GetFirst()?.Data);
        }

        [Fact]
        public void MustGetLastNodeOfList()
        {
            var list = new LinkedList();
            Assert.Null(list.GetLast()?.Data);
            list.InsertFirst(13);
            Assert.Equal(13, list.GetLast()?.Data);
            list.InsertFirst(7);
            Assert.Equal(13, list.GetLast()?.Data);
        }

        [Fact]
        public void MustEmptyList()
        {
            var list = new LinkedList();
            list.InsertFirst(1);
            list.InsertFirst(1);
            list.InsertFirst(1);
            Assert.Equal(3, list.Size());
            list.Clear();
            Assert.Equal(0, list.Size());
            Assert.Null(list.GetLast()?.Data);
            Assert.Null(list.GetFirst()?.Data);
        }

        [Fact]
        public void MustRemoveFirst()
        {
            var list = new LinkedList();
            list.InsertFirst('a');
            list.RemoveFirst();
            Assert.Equal(0, list.Size());
            Assert.Null(list.GetLast()?.Data);
            Assert.Null(list.GetFirst()?.Data);
            list.InsertFirst('c');
            list.InsertFirst('b');
            list.InsertFirst('a');
            list.RemoveFirst();
            Assert.Equal('b', list.GetFirst()?.Data);
            Assert.Equal(2, list.Size());
        }
    }
}