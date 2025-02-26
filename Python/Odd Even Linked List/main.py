class Node:
    def __init__(self, value):
        self.value = value
        self.next = None
class LinkedListNode:
    def __init__(self):
        self.head = None
    def append(self, data):
        new_node = Node(data)
        if self.head is None:
            self.head = new_node
            return
        last_node = self.head
        while last_node.next:
            last_node = last_node.next
        last_node.next = new_node
    def print_list(self):
        node = self.head
        while node:
            print(node.value, end=' ')
            node = node.next
        print()
    def solve_odd_even_linked_list(self):
        if self.head is None:
            return
        odd_head, odd = None, None
        even_head, even = None, None
        node = self.head
        is_even = False
        while node:
            if is_even:
               if even is None:
                    even_head = node
                    even = node
               else:
                    even.next = node
                    even = even.next
            else:
                if odd is None:
                    odd_head = node
                    odd = node
                else:
                    odd.next = node
                    odd = odd.next       
            node = node.next
            is_even = not is_even

        if odd:
            odd.next = even_head
        if even:
            even.next = None

        if odd_head:
            self.head = odd_head
        else:
            self.head = even_head
    
test = LinkedListNode()

test.append(1)

test.append(2)

test.append(3)

test.solve_odd_even_linked_list()

test.print_list()