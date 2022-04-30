//https://leetcode.com/problems/palindrome-linked-list/

//Given the head of a singly linked list, return true if it is a palindrome.

//Example 1:

//Input: head = [1, 2, 2, 1]
//Output: true

//Example 2:

//Input: head = [1, 2]
//Output: false

//Constraints:

//The number of nodes in the list is in the range [1, 105].
//    0 <= Node.val <= 9

//Follow up: Could you do it in O(n) time and O(1) space ?

namespace LeetCode.Problems._234._Palindrome_Linked_List;

internal class IsPalindrome
{
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
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public static bool Solution(ListNode head)
    {
        ListNode l = head; int length = 0, middle = 0;
        while (l is not null)
        {
            length++; l = l.next;
        }
        if (length == 1 || length == 0) return true;
        middle = length - length / 2 - 1;
        l = head;
        for (int i = 0; i < middle; i++)
        {
            l = l.next;
        }
        ListNode l1 = l.next, l2 = null!;
        while (l1.next is not null)
        {
            l2 = l1.next;
            l1.next = l1.next.next;
            l2.next = l.next;
            l.next = l2;
        }
        l1 = head; l2 = head;
        while (middle >= 0) { l2 = l2.next; middle--; }
        while (l2 is not null)
        {
            if (l1.val != l2.val) return false;
            l1 = l1.next; l2 = l2.next;
        }
        return true;
    }
}
