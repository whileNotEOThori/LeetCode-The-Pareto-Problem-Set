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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        //get length of linked list
        int length = 1;
        ListNode curr = head;
        ListNode secondLast = null;
        while(curr.next != null)
        {
            if (curr.next.next == null)
                secondLast = curr;

            length++;
            curr = curr.next;
        }

        //if n is first node
        if (n == length)
            return head.next;

        //if n is last node
        if (n == 1)
        {
            secondLast.next = null;
            return head;
        }

        //id n is in the middle
        curr = head;
        for (int i = 1; i < length - n; i++)
        {
            curr = curr.next;
        }

        curr.next = curr.next.next;

        return head;
    }
}