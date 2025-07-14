namespace LeetCode.LC21;

public class LeetCode21
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

    public ListNode MergeTwoLists(ListNode head1, ListNode head2) {
        if (head1 == null)
            return head2;
        if (head2 == null)
            return head1;

        if (head1.val <= head2.val) {
            head1.next = MergeTwoLists(head1.next, head2);
            return head1;
        }
        else {
            head2.next = MergeTwoLists(head1, head2.next);
            return head2;
        }
    }
}