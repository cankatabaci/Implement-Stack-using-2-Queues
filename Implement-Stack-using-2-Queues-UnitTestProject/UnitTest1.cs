using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Implement_Stack_using_2_Queues;

namespace Implement_Stack_using_2_Queues_UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DoesThrowingErrorWhenQueue1IsEmpty()
        {
            Stack s = new Stack();
            s.Pop();
        }

        [TestMethod]
        public void DoesReturnTrueValueWhenStackIsFull()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);

            string expectedExpression = "2";
            string realExpression = s.Pop().ToString();

            Assert.AreEqual(expectedExpression, realExpression);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DoesThrowingErrorWhenElementAddedWhileQueueIsFull()
        {
            Queue q = new Queue(1);
            q.Enqueue(0);
            q.Enqueue(1);
        }

        [TestMethod]
        public void DoesElementAddedWhenTheQueueIsEmpty()
        {
            Queue q = new Queue(1);
            q.Enqueue(1);
            string expectedExpression = "1 ";
            string realExpression = q.DisplayElements();

            Assert.AreEqual(expectedExpression, realExpression);

        }

        [TestMethod]
        public void DoesAddElementsWhenQueueHasElements()
        {
            Queue q = new Queue(3);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            string expectedExpression = "1 2 3 ";
            string realExpression = q.DisplayElements();

            Assert.AreEqual(expectedExpression, realExpression);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesThrowingErrorWhileQueueIsEmpty()
        {
            Queue q = new Queue(2);
            q.DisplayElements();
        }

        [TestMethod]
        public void DoesDisplayElementsWhenQueueHasElements()
        {
            Queue q = new Queue(2);
            q.Enqueue(1);
            q.Enqueue(2);

            string expectedExpression = "1 2 ";
            string realExpression = q.DisplayElements();

            Assert.AreEqual(expectedExpression, realExpression);
        }

        [TestMethod]
        public void DoesReadCorrectlyWhileFirstElementOfQueueIsEmpty()
        {
            Queue q = new Queue(4);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Dequeue();

            string expectedExpression = "2 3 4 ";
            string realExpression = q.DisplayElements();

            Assert.AreEqual(expectedExpression, realExpression);
        }

        [TestMethod]
        public void DoesReturnTrueWhenQueueIsEmpty()
        {
            Queue q = new Queue(2);
            bool expectedExpression = true;
            bool realExpression = q.IsEmpty();

            Assert.AreEqual(expectedExpression, realExpression);
        }

        [TestMethod]
        public void DoesReturnFalseWhenQueueIsFalse()
        {
            Queue q = new Queue(2);
            q.Enqueue(1);

            bool expectedExpression = false;
            bool realExpression = q.IsEmpty();

            Assert.AreEqual(expectedExpression, realExpression);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesThrowingErrorWhileQueueIsEmptyForPeekMethod()
        {
            Queue q = new Queue(2);
            q.Peek();
        }

        [TestMethod]
        public void DoesPeekElementWhenQueueIsFull()
        {
            Queue q = new Queue(3);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            int expectedExpression = 1;
            int realExpression = Convert.ToInt32(q.Peek());

            Assert.AreEqual(expectedExpression, realExpression);
        }

        [TestMethod]
        public void DoesDeleteElementWhenQueueIsFull()
        {
            Queue q = new Queue(3);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();

            string expectedExpression = "2 3 ";
            string realExpression = q.DisplayElements();

            Assert.AreEqual(expectedExpression, realExpression);
        }

    }
}
