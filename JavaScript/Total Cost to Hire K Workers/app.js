/*Example 1:

Input: costs = [17,12,10,2,7,2,11,20,8], k = 3, candidates = 4
Output: 11
Explanation: We hire 3 workers in total. The total cost is initially 0.
- In the first hiring round we choose the worker from [17,12,10,2,7,2,11,20,8]. The lowest cost is 2, and we break the tie by the smallest index, which is 3. The total cost = 0 + 2 = 2.
- In the second hiring round we choose the worker from [17,12,10,7,2,11,20,8]. The lowest cost is 2 (index 4). The total cost = 2 + 2 = 4.
- In the third hiring round we choose the worker from [17,12,10,7,11,20,8]. The lowest cost is 7 (index 3). The total cost = 4 + 7 = 11. Notice that the worker with index 3 was common in the first and last four workers.
The total hiring cost is 11.
Example 2:

Input: costs = [1,2,4,1], k = 3, candidates = 3
Output: 4
Explanation: We hire 3 workers in total. The total cost is initially 0.
- In the first hiring round we choose the worker from [1,2,4,1]. The lowest cost is 1, and we break the tie by the smallest index, which is 0. The total cost = 0 + 1 = 1. Notice that workers with index 1 and 2 are common in the first and last 3 workers.
- In the second hiring round we choose the worker from [2,4,1]. The lowest cost is 1 (index 2). The total cost = 1 + 1 = 2.
- In the third hiring round there are less than three candidates. We choose the worker from the remaining workers [2,4]. The lowest cost is 2 (index 0). The total cost = 2 + 2 = 4.
The total hiring cost is 4.*/

const costs = [25,20,60,21,11,99,55,22,83,62,12,63,100,41,33,92,13,92,58,85,61,93,5,46,26,25,36,27,12,30,13,52,30]
const k = 8;
const candidates = 22;

class MinHeap {
    constructor() {
      this.heap = [];
    }
    push(val) {
      this.heap.push(val);
      this.bubbleUp();
    }
    bubbleUp() {
      let i = this.heap.length - 1;
      while (i > 0) {
        let parent = Math.floor((i - 1) / 2);
        if (this.heap[i] < this.heap[parent]) {
          [this.heap[i], this.heap[parent]] = [this.heap[parent], this.heap[i]];
          i = parent;
        } else {
          break;
        }
      }
    }
    pop() {
      if (this.heap.length === 0) return null;
      const min = this.heap[0];
      this.heap[0] = this.heap[this.heap.length - 1];
      this.heap.pop();
      this.bubbleDown(0);
      return min;
    }
    bubbleDown(i) {
      const n = this.heap.length;
      while (true) {
        let left = 2 * i + 1, right = 2 * i + 2;
        let smallest = i;
        if (left < n && this.heap[left] < this.heap[smallest]) {
          smallest = left;
        }
        if (right < n && this.heap[right] < this.heap[smallest]) {
          smallest = right;
        }
        if (smallest !== i) {
          [this.heap[i], this.heap[smallest]] = [this.heap[smallest], this.heap[i]];
          i = smallest;
        } else {
          break;
        }
      }
    }
    peek() {
      return this.heap.length > 0 ? this.heap[0] : null;
    }
    size() {
      return this.heap.length;
    }
}

var totalCost = function(costs, k, candidates) {
    let totalCost = 0;
    let n = costs.length;
    let left = 0, right = n - 1;
    const leftHeap = new MinHeap();
    const rightHeap = new MinHeap();
    
    // Lấy ứng viên từ bên trái
    for (let i = 0; i < candidates && left <= right; i++) {
      leftHeap.push(costs[left]);
      left++;
    }
    // Lấy ứng viên từ bên phải
    for (let i = 0; i < candidates && left <= right; i++) {
      rightHeap.push(costs[right]);
      right--;
    }
    
    // Thuê k công nhân
    for (let i = 0; i < k; i++) {
      if (rightHeap.size() === 0 || (leftHeap.size() > 0 && leftHeap.peek() <= rightHeap.peek())) {
        totalCost += leftHeap.pop();
        if (left <= right) {
          leftHeap.push(costs[left]);
          left++;
        }
      } else {
        totalCost += rightHeap.pop();
        if (left <= right) {
          rightHeap.push(costs[right]);
          right--;
        }
      }
    }
    
    return totalCost;
  };

console.log(totalCost(costs, k, candidates));
