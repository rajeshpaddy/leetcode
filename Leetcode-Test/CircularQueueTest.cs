using System;
using Xunit;
using LeetCode_CircularQueue;
namespace Leetcode_Test
{
    public class CircularQueueTest
    {
        [Fact]
        public void increaseREARUnitTest()
        {
<<<<<<< HEAD
            int test;
=======
            MyCircularQueue c = new MyCircularQueue(5);


        }
        [Fact]
        public void enquedequeUnitTest()
        {
            MyCircularQueue c = new MyCircularQueue(2);
            Assert.True(c.EnQueue(4));
            Assert.Equal(4,c.Rear());
            Assert.True(c.EnQueue(9));
            Assert.True(c.DeQueue());
            Assert.Equal(9, c.Front());
            Assert.True(c.DeQueue());
            Assert.True(c.IsEmpty());
            Assert.False(c.DeQueue());
            Assert.True(c.EnQueue(6));
            Assert.True(c.EnQueue(4));


        }

        [Fact]
        public void enqueueTest()
        {
            MyCircularQueue c = new MyCircularQueue(6);
            Assert.True(c.EnQueue(1));
            Assert.Equal(1, c.Rear());
            Assert.True(c.EnQueue(2));
            Assert.Equal(2, c.Rear());
            Assert.True(c.EnQueue(3));
            Assert.Equal(3, c.Rear());
            Assert.True(c.EnQueue(4));
            Assert.Equal(4, c.Rear());
            Assert.True(c.EnQueue(5));
            Assert.Equal(5, c.Rear());
            Assert.True(c.EnQueue(6));
            Assert.True(c.DeQueue());
            Assert.Equal(2, c.Front());
            Assert.True(c.EnQueue(6));
            Assert.Equal(6, c.Rear());
        }

        [Fact]
        public void dequeueTest()
        {
            MyCircularQueue c = new MyCircularQueue(5);
            Assert.False(c.DeQueue());
            Assert.Equal(-1, c.Rear());
            Assert.True(c.EnQueue(1));
            Assert.Equal(1, c.Rear());
            Assert.True(c.EnQueue(2));
            Assert.Equal(2, c.Rear());
            Assert.True(c.DeQueue());
            Assert.True(c.DeQueue());
            Assert.False(c.DeQueue());
            Assert.Equal(-1, c.Front());
            Assert.Equal(-1, c.Front());
        }

        [Fact]
        public void REARFRONTTest()
        {
            MyCircularQueue c = new MyCircularQueue(5);
            Assert.True(c.EnQueue(36));
            Assert.True(c.EnQueue(42));
            Assert.True(c.EnQueue(56));
            Assert.Equal(36, c.Front());
            Assert.Equal(56, c.Rear());
            Assert.True(c.DeQueue());
            Assert.Equal(42, c.Front());
            Assert.True(c.DeQueue());
            Assert.Equal(56, c.Front());
            Assert.Equal(56, c.Rear());
            Assert.True(c.DeQueue());
            Assert.Equal(-1, c.Front());
            Assert.Equal(-1, c.Rear());
        }

        [Fact]
        public void isEmptyTest()
        {
            MyCircularQueue c = new MyCircularQueue(5);
            Assert.True(c.IsEmpty());
            Assert.True(c.EnQueue(36));
            Assert.False(c.IsEmpty());
        }
        [Fact]
        public void isFullTest()
        {
            MyCircularQueue c = new MyCircularQueue(1);
            Assert.False(c.IsFull());
            Assert.True(c.EnQueue(36));
            Assert.True(c.IsFull());
>>>>>>> 1f72bfd... SimpleThinker and Twitterexplorer API
        }
    }
}

