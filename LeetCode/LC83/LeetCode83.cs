namespace LeetCode.LC83;

public class LeetCode83
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode result = head;
        while (head != null)
        {
            if (head.next != null)
            {
                if (head.val == head.next.val) 
                    head.next = head.next.next;
                else head = head.next;
                    
            }
            else if (head.next == null)
                break;
        }

        return result;
    }

    public void Run()
    {
        ListNode head = new ListNode(1, null);
        head.next = new ListNode(1, null);
        head.next.next = new ListNode(2, null);
        head.next.next.next = new ListNode(3, null);
        head.next.next.next.next = new ListNode(3, null);
        DeleteDuplicates(head);
    }
}