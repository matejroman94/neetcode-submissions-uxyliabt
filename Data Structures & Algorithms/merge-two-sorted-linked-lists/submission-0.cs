/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            ListNode? newHead = null;
            ListNode? newTail = null;

            ListNode? x = list1;
            ListNode? y = list2;

            while(x != null ||
                y != null)
            {
                ListNode? nextNode = null;
                if (x == null && y != null) 
                {
                    nextNode = new ListNode(y.val);
                    y = y.next;
                }
                if(y == null && x != null) 
                {
                    nextNode = new ListNode(x.val);
                    x = x.next;
                }

                if(nextNode is null)
                {
                    if (x!.val >= y!.val)
                    {
                        nextNode = new ListNode(y.val);
                        y = y.next;
                    }
                    else
                    {
                        nextNode = new ListNode(x.val);
                        x = x.next;
                    }
                }

                if (newTail is null) newTail = newHead = nextNode;
                else 
                {
                    newTail.next = nextNode;
                    newTail = newTail.next;
                }
            }

            return newHead;
    }
}