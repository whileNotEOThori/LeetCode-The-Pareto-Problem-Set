/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) 
    {
        //empty list
        if (head == null)
            return false;
        
        //single node list
        if (head.next == null)
            return false;

        /*//two node circular list
        if (head.next.next == head)
            return true;
        
        ListNode curr = head;
        int pos = 0, count = 0;

        while (pos >= count)
        {
            pos++;
            count++;

            if (curr.next != head)
        }

        return false;*/

        Dictionary<ListNode,int> nodes = new Dictionary<ListNode,int>();
        int i = 0;

        
            while (head.next != null)
            {
                try
                {
                    nodes.Add(head,i);
                }
                catch (ArgumentException)
                {
                    return true;
                }
                head = head.next;
                i++;
            }
            return false;
        }
    }