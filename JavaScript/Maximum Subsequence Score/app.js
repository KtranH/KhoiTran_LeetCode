/*Example 1:

Input: nums1 = [1,3,3,2], nums2 = [2,1,3,4], k = 3
Output: 12
Explanation: 
The four possible subsequence scores are:
- We choose the indices 0, 1, and 2 with score = (1+3+3) * min(2,1,3) = 7.
- We choose the indices 0, 1, and 3 with score = (1+3+2) * min(2,1,4) = 6. 
- We choose the indices 0, 2, and 3 with score = (1+3+2) * min(2,3,4) = 12. 
- We choose the indices 1, 2, and 3 with score = (3+3+2) * min(1,3,4) = 8.
Therefore, we return the max score, which is 12.
Example 2:

Input: nums1 = [4,2,3,1,1], nums2 = [7,5,10,9,6], k = 1
Output: 30
Explanation: 
Choosing index 2 is optimal: nums1[2] * nums2[2] = 3 * 10 = 30 is the maximum possible score.*/

const nums1 = [1, 3, 3, 2];
const nums2 = [2, 1, 3, 4];
const k = 3;

function heapify(i, heap) {
    const leftChild = (i) => 2 * i + 1;
    const rightChild = (i) => 2 * i + 2;
    const left = leftChild(i);
    const right = rightChild(i);
    let smallest = i;
    if (left < heap.length && heap[left] < heap[smallest]) {
        smallest = left;
    }
    if (right < heap.length && heap[right] < heap[smallest]) {
        smallest = right;
    }
    if (smallest !== i) {
        [heap[i], heap[smallest]] = [heap[smallest], heap[i]];
        heapify(smallest, heap);
    }
}
function insert(val, heap) {
    const parent = (i) => Math.floor((i - 1) / 2);
    heap.push(val);
    let i = heap.length - 1;
    while (i > 0 && heap[i] < heap[parent(i)]) {
        [heap[i], heap[parent(i)]] = [heap[parent(i)], heap[i]];
        i = parent(i);
    }
}
function peekMin(heap) {
    if (heap.length === 0) throw new Error('Heap is empty');
    return heap[0];
}
function popMin(heap) {
    if (heap.length === 0) throw new Error('Heap is empty');
    const min = heap[0];
    heap[0] = heap[heap.length - 1];
    heap.pop();
    heapify(0, heap);
    return min;
}
function solve_maximum_subsequence_score(nums1, nums2, k) {
    const sortedIndices = Array.from(nums2.keys()).sort((a, b) => nums2[b] - nums2[a]);
    const heap = [];
    let sumSelected = 0;
    let maxResult = 0;

    for (let i = 0; i < sortedIndices.length; i++) {
        const index = sortedIndices[i];
        if (heap.length < k) {
            insert(nums1[index], heap);
            sumSelected += nums1[index];
        } else {
            if (nums1[index] > peekMin(heap)) {
                sumSelected += nums1[index] - popMin(heap);
                insert(nums1[index], heap);
            }
        }

        if (heap.length === k) {
            maxResult = Math.max(maxResult, sumSelected * nums2[index]);
        }
    }

    return maxResult;
}

console.log(solve_maximum_subsequence_score(nums1, nums2, k, heap));

