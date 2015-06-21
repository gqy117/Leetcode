namespace Leetcode
{
    public class RemoveNthNodeFromEndOfList
    {
        public static ListNode Solution(ListNode head, int n)
        {
            int count = GetCount(head);

            int nodeToBeRemoved = count - n;
            int nodeBeforeRemoved = nodeToBeRemoved - 1;

            if (IsTryingToRemoveTheFirstNode(nodeToBeRemoved))
            {
                return head.next;
            }
            else
            {
                int i = 0;
                var theNode = FindNodeBeforeRemoved(head, i, nodeBeforeRemoved);
                theNode.next = theNode.next.next; 
            }

            return head;
        }

        private static ListNode FindNodeBeforeRemoved(ListNode head, int i, int nodeBeforeRemoved)
        {
            var subNode = head;

            while (subNode != null)
            {
                if (i == nodeBeforeRemoved)
                {
                    return subNode;
                }

                subNode = subNode.next;
                i++;
            }

            return null;
        }

        private static bool IsTryingToRemoveTheFirstNode(int nodeToBeRemoved)
        {
            return 0 == nodeToBeRemoved;
        }

        private static int GetCount(ListNode head)
        {
            int count = 0;
            var subNode = head;

            while (subNode != null)
            {
                subNode = subNode.next;
                count++;
            }

            return count;
        }
    }
}