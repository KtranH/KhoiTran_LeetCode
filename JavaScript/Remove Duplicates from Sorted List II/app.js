/*
Example 1:

Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:

Input: head = [1,1,1,2,3]
Output: [2,3]
*/

function ListNode(val = 0, next = null)
{
    this.val = val;
    this.next = next;
}
function solve_remove_duplicates_from_sorted_list_ii(head)
{
    if (!head) return null;
    let dummy = new ListNode(0);
    dummy.next = head;
    let prev = dummy;
    while (prev.next && prev.next.next) {
        if (prev.next.val === prev.next.next.val) {
            let dup_val = prev.next.val;
            while (prev.next && prev.next.val === dup_val) {
                prev.next = prev.next.next;
            }
        } else {
            prev = prev.next;
        }
    }
    return dummy.next;
}

let head = [1,2,3,3,4,4,5];
console.log(solve_remove_duplicates_from_sorted_list_ii(head));
