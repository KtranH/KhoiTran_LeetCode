list1 = [1,2,4]
list2 = [1,3,4]

"""
Example 1:

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
"""

class ListNode
{
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
    
    def mergeTwoLists(self, list1, list2):
        dummy = ListNode()
        current = dummy
        while list1 and list2:
            if list1.val < list2.val:
                current.next = list1
                list1 = list1.next
            else:
                current.next = list2
                list2 = list2.next
            current = current.next
        current.next = list1 or list2
        return dummy.next
}   

list1 = [1,2,4]
list2 = [1,3,4]
result = list1.mergeTwoLists(list1, list2)
print(result)

    