namespace Leetcode
{
    using System;

    public class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);

            var subNodeL1 = l1;
            var subNodeL2 = l2;
            var subResult = result;

            while (subNodeL1 != null && subNodeL2 != null)
            {
                subResult.val = subNodeL1.val + subNodeL2.val;

                subNodeL1 = subNodeL1.next;
                subNodeL2 = subNodeL2.next;
                if (subNodeL1 != null && subNodeL2 != null)
                {
                    subResult.next = new ListNode(0);
                    subResult = subResult.next;
                }
            }

            return result;
        }
    }
}