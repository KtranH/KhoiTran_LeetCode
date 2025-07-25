class ListNode:
    def __init__(self, val = 0, next = None):
        self.val = val
        self.next = next
    def solve_reverse_linked_list_ii(self, head: Optional[ListNode], left: int, right: int) -> Optional[ListNode]:
        if not head or left == right:
            return head
        
        # giả sử list node là [1,2,3,4,5] và left = 2, right = 4
        # ta sẽ tạo ra list node [0,1,2,3,4,5]
        dummy = ListNode(0)
        dummy.next = head # dummy.next = node 1
        prev = dummy # prev = node 0
        
        # di chuyển prev đến node trước node left
        for _ in range(left - 1):
            prev = prev.next # prev = node 1
        
        # reverse list node từ node left đến node right
        reverse = None
        curr = prev.next # curr = node 2
        for _ in range(right - left + 1):
            next_node = curr.next 
            curr.next = reverse
            reverse = curr 
            curr = next_node 

            #Quy trình minh họa
            #tại lần lặp đầu tiên
            #next_node = node 3
            #curr.next = None
            #reverse = node 2
            #curr = node 3

            #tại lần lặp thứ 2
            #next_node = node 4
            #curr.next = node 2
            #reverse = node 3
            #curr = node 4

            #tại lần lặp thứ 3
            #next_node = node 5
            #curr.next = node 3
            #reverse = node 4
            #curr = node 5

        # nối lại list node
        prev.next.next = curr # nối node 1.next.next = node 4
        prev.next = reverse # nối node 1.next = node 2
        
        return dummy.next 

# Example usage:
head = ListNode(1)
head.next = ListNode(2)
head.next.next = ListNode(3)
head.next.next.next = ListNode(4)
head.next.next.next.next = ListNode(5)

left = 2
right = 4

result = head.solve_reverse_linked_list_ii(head, left, right)

# Print the reversed list
while result:
    print(result.val, end=" ")
    result = result.next
