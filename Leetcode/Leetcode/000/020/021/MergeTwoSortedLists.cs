namespace Leetcode
{
    using System;

    public class MergeTwoSortedLists
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode tempResult = result;
            ListNode subL1 = l1;
            ListNode subL2 = l2;

            while (subL1 != null || subL2 != null)
            {
                if (GetValue(subL1) < GetValue(subL2))
                {
                    SetResultNext(tempResult, subL1);
                    subL1 = GotoNextNode(subL1);
                }
                else
                {
                    SetResultNext(tempResult, subL2);
                    subL2 = GotoNextNode(subL2);
                }

                tempResult = GotoNextNode(tempResult);
            }

            return result.next;
        }

        private static int GetValue(ListNode subListNode)
        {
            return subListNode == null ? int.MaxValue : subListNode.val;
        }

        private static ListNode GotoNextNode(ListNode listNode)
        {
            listNode = listNode.next;

            return listNode;
        }

        private static void SetResultNext(ListNode result, ListNode subList)
        {
            result.next = subList;
        }
    }
}
