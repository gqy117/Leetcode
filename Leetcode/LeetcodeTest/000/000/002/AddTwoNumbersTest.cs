namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class AddTwoNumbersTest
    {
        [Test]
        public void TwoSum_Default()
        {
            ListNode l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            ListNode l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(3)
                }
            };

            ListNode expected = new ListNode(7)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(8)
                }
            };

            this.ExecuteSolution(l1, l2, expected);
        }

        private void ExecuteSolution(ListNode l1, ListNode l2, ListNode expected)
        {
            // Act
            var actual = AddTwoNumbers.Solution(l1, l2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
