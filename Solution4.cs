// Solution4: https://leetcode.com/explore/interview/card/top-interview-questions-easy/93/linked-list/771/
namespace LeetCodeTasks;

public class ListNode {
    public int val;       
    public ListNode next;   

    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}
public class Solution4 {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;
        
        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                current.next = list1;
                list1 = list1.next;
            } else {
                current.next = list2;
                list2 = list2.next;
            }
            
            current = current.next;
        }
        
        if (list1 != null) {
            current.next = list1;
        } else {
            current.next = list2;
        }
        
        return dummy.next;
    }
}
