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
        //list remains unchanged if there is only one node
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

        // list remains unchanged if there are only two nodes
        if (numNodes == 1)
            return ;

        ListNode result = head;
        curr = head;

        int i =0;
        while (i < numNodes)
        {
            //reassign curr
            curr = head;
            
            //find second last node
            while(curr.next != tail)
                curr = curr.next;

            curr.next = null;

            //put tail in between nodes
            tail.next = head.next;

            head.next = tail;

            // set tail to the second last node
            tail = curr;

            //set head to the node after the new insertion | essentailly the next odd numbered node
            head = head.next.next;

            i = i+2;
        }

        // set the head to the reordered list
        head = result;
    }
}