namespace LeetcodeTest
{
    using FluentAssertions;
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class MergeTwoSortedListsTest
    {
        [Test]
        public void MergeTwoSortedLists_Default()
        {
            ListNode l1 = new ListNode(1)
            {
                next = new ListNode(2)
            };

            ListNode l2 = new ListNode(3)
            {
                next = new ListNode(4)
            };

            ListNode expected = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                }
            };

            this.ExecuteSolution(l1, l2, expected);
        }

        [Test]
        public void MergeTwoSortedLists_NotSorted()
        {
            ListNode l1 = new ListNode(1)
            {
                next = new ListNode(3)
            };

            ListNode l2 = new ListNode(2)
            {
                next = new ListNode(4)
            };

            ListNode expected = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                }
            };

            this.ExecuteSolution(l1, l2, expected);
        }

        [Test]
        public void MergeTwoSortedLists_1()
        {
            ListNode l1 = new ListNode(1);

            ListNode l2 = new ListNode(2);

            ListNode expected = new ListNode(1)
            {
                next = new ListNode(2)
            };

            this.ExecuteSolution(l1, l2, expected);
        }

        [Test]
        public void MergeTwoSortedLists_l1Null()
        {
            ListNode l1 = null;

            ListNode l2 = new ListNode(2);

            ListNode expected = new ListNode(2);

            this.ExecuteSolution(l1, l2, expected);
        }

        [Test]
        public void MergeTwoSortedLists_l2Null()
        {
            ListNode l1 = new ListNode(2);

            ListNode l2 = null;

            ListNode expected = new ListNode(2);

            this.ExecuteSolution(l1, l2, expected);
        }

        private void ExecuteSolution(ListNode l1, ListNode l2, ListNode expected)
        {
            // Act
            var actual = MergeTwoSortedLists.Solution(l1, l2);

            // Assert
            expected.ShouldBeEquivalentTo(actual);
        }
    }
}
