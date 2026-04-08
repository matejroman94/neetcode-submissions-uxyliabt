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
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode mergedList = null;
        ListNode head = null;

        if (lists.Length == 0) return head;

        while (true)
        {
            int k = 1;
            int index = 0;
            ListNode minListNode = lists[index];
            while (k < lists.Length)
            {
                if (minListNode is null || minListNode.val > lists[k]?.val)
                {
                    index = k;
                    minListNode = lists[index];
                }
                ++k;
            }

            if (minListNode is null) return head;

            // Add to the merged list
            if (mergedList is null)
            {
                mergedList = new ListNode(minListNode.val);
                head = mergedList;
            }
            else
            {
                mergedList.next = new ListNode(minListNode.val);
                mergedList = mergedList.next;
            }

            // Increment listNode
            lists[index] = minListNode.next;
        }
    }
}
