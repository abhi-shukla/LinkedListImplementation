using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListApp;

namespace LinkedListAppTests
{
    [TestClass]
    public class MyLinkedListTests
    {
        [TestMethod]
        public void Remove_MiddleElement_ShouldRemovetheMiddleElementFromList()
        {
            // Arrange
            var actualList = new MyLinkedList<int>();
            actualList.Add(3);
            actualList.Add(5);
            actualList.Add(7);

            // Act
            actualList.Remove(5);

            // Assert
            Assert.AreEqual(7, actualList.Head.Value);
            Assert.AreEqual(3, actualList.Tail.Value);
            Assert.AreEqual(2, actualList.Count);
        }

        [TestMethod]
        public void Remove_FirstElement_ShouldRemoveHead()
        {
            // Arrange
            var actualList = new MyLinkedList<string>();
            actualList.Add("3");
            actualList.Add("5");
            actualList.Add("7");

            // Act
            actualList.Remove("7");

            // Assert
            Assert.AreEqual("5", actualList.Head.Value);
            Assert.AreEqual("3", actualList.Tail.Value);
            Assert.AreEqual(2, actualList.Count);
        }

        [TestMethod]
        public void Remove_LastElement_ShouldRemoveTail()
        {
            // Arrange
            var actualList = new MyLinkedList<string>();
            actualList.Add("3");
            actualList.Add("5");
            actualList.Add("7");

            // Act
            actualList.Remove("3");

            // Assert
            Assert.AreEqual("7", actualList.Head.Value);
            Assert.AreEqual("5", actualList.Tail.Value);
            Assert.AreEqual(2, actualList.Count);
        }
    }
}
