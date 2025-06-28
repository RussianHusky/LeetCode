using System.Numerics;

namespace LeetCode.LC02;

public class LeetCode02 : ILeetCodeSolution
{
    public class ListNode {
         public int val;
             public ListNode next;
             public ListNode(int val = 0, ListNode next = null)
             {
                 this.val = val;
                 this.next = next;
             }
    }
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        BigInteger firstNum = 0, secondNum = 0;
        {
            BigInteger i = 0;
            while (l1 != null)
            {
                firstNum += (BigInteger)(l1.val * BigInteger.Pow(10, (int)i));
                l1 = l1.next;
                i++;
            }

            i = 0;
            while (l2 != null)
            {
                secondNum += (BigInteger)(l2.val * BigInteger.Pow(10, (int)i));
                l2 = l2.next;
                i++;
            }
        }
        BigInteger buffer = firstNum + secondNum;
        ListNode finalRes = new ListNode();
        ListNode headRes = finalRes;
        while (Math.Floor((double)buffer) > 0)
        {
            if (Math.Floor((double)buffer / 10) > 0)
            {
                finalRes.val = (int)(buffer % 10);
                buffer /= 10;
                finalRes.next = new ListNode();
                finalRes = finalRes.next;
            }
            else
            {
                finalRes.val = (int)(buffer % 10);
                buffer /= 10;
            }

            Math.Floor((double)buffer);
        }

        return headRes;
    }
    
    public void Run()
    {
        //Console.WriteLine(AddTwoNumbers());
    }
}