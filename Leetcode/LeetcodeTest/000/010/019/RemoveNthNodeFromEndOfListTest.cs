namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class RemoveNthNodeFromEndOfListTest
    {
        [Test]
        public void RemoveNthNodeFromEndOfList_Default()
        {
            ListNode head = new ListNode(1);
            int n = 1;
            ListNode expected = null;

            this.ExecuteSolution(head, n, expected);
        }

        private void ExecuteSolution(ListNode head, int n, ListNode expected)
        {
            // Act
            var actual = RemoveNthNodeFromEndOfList.Solution(head, n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
