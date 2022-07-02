namespace LeetCode.Problems._2._Add_Two_Numbers;

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

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var valAndrem = FindValue(l1.val, l2.val, false);
        ListNode head = new ListNode(valAndrem.valu);
        ListNode l3 = head;
        l1 = l1.next; l2 = l2.next;
        while (l1 != null || l2 != null)
        {
            if (l1 == null && l2 != null)
            {
                var valAndrem2 = FindValue(0, l2.val, valAndrem.remainder);
                l3.next = new ListNode(valAndrem2.valu);
                l3 = l3.next; l2 = l2.next;
                valAndrem = valAndrem2;
            }
            if (l2 == null && l1 != null)
            {
                var valAndrem2 = FindValue(l1.val, 0, valAndrem.remainder);
                l3.next = new ListNode(valAndrem2.valu);
                l3 = l3.next; l1 = l1.next;
                valAndrem = valAndrem2;
            }
            else if (l1 != null && l2 != null)
            {
                var valAndrem2 = FindValue(l1.val, l2.val, valAndrem.remainder);
                l3.next = new ListNode(valAndrem2.valu);
                l3 = l3.next; l1 = l1.next; l2 = l2.next;
                valAndrem = valAndrem2;
            }
        }
        if (valAndrem.remainder) l3.next = new ListNode(1);
        return head;
    }

    public static (int valu, bool remainder) FindValue(int l1, int l2, bool remainder)
    {
        int valu = l1 + l2 + Convert.ToInt16(remainder);
        if (valu > 9)
        {
            remainder = true; valu -= 10;
        }
        else remainder = false;
        var valAndrem = (valu: valu, remainder: remainder);
        return valAndrem;
    }
}


////Solution 2:

//public class Solution
//{
//    public class _002_AddTwoNumbers
//    {
//        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
//        {
//            var dummy = new ListNode(-1);
//            var current = dummy;

//            var carry = 0;
//            while (l1 != null || l2 != null)
//            {
//                var value1 = l1 == null ? 0 : l1.val;
//                var value2 = l2 == null ? 0 : l2.val;

//                var sum = value1 + value2 + carry;
//                carry = sum / 10;
//                sum %= 10;
//                current.next = new ListNode(sum);

//                current = current.next;
//                l1 = l1 == null ? null : l1.next;
//                l2 = l2 == null ? null : l2.next;
//            }

//            if (carry != 0)
//                current.next = new ListNode(carry);

//            return dummy.next;
//        }
//    }
//}