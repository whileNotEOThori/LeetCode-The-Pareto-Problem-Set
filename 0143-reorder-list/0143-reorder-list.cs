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
    public void ReorderList(ListNode head) {
        //return list as is if there is only one node
        if (head.next == null)
            return ;

        //find number of nodes and the tail
        int numNodes = 0;
        ListNode tail = new ListNode();
        ListNode curr = head;

        while (curr.next != null)
        {
            numNodes++;
            curr = curr.next;
        }
        tail = curr;

        if (numNodes == 1)
            return ;

        ListNode result = head;
        curr = head;

        int i =0;
        while (i < numNodes)
        {
            curr = head;
            
            //find second last node
            while(curr.next != tail)
                curr = curr.next;

            curr.next = null;

            //put tail in between nodes
            tail.next = head.next;

            head.next = tail;

            tail = curr;

            head = head.next.next;

            i = i+2;
        }

        head = result;
    }
}