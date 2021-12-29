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
    }
}
