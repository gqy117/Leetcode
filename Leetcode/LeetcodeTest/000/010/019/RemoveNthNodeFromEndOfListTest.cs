namespace LeetcodeTest
{
    using FluentAssertions;
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class RemoveNthNodeFromEndOfListTest
    {
        [TestCase(2)]
        public void RemoveNthNodeFromEndOfList_Default(int n)
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            ListNode expected = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(5)
                    }
                }
            };

            this.ExecuteSolution(head, n, expected);
        }

        [TestCase(1)]
        public void RemoveNthNodeFromEndOfList_RemoveLast(int n)
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
            };

            ListNode expected = new ListNode(1);

            this.ExecuteSolution(head, n, expected);
        }

        [TestCase(1)]
        public void RemoveNthNodeFromEndOfList_RemoveOneself(int n)
        {
            ListNode head = new ListNode(1);

            ListNode expected = null;

            this.ExecuteSolution(head, n, expected);
        }

        [TestCase(2)]
        public void RemoveNthNodeFromEndOfList_RemoveFirst(int n)
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
            };

            ListNode expected = new ListNode(2);

            this.ExecuteSolution(head, n, expected);
        }

        private void ExecuteSolution(ListNode head, int n, ListNode expected)
        {
            // Act
            var actual = RemoveNthNodeFromEndOfList.Solution(head, n);

            // Assert
            expected.ShouldBeEquivalentTo(actual);
        }
    }
}
