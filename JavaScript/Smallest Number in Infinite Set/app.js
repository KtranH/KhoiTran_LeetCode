/*Example 1:

Input
["SmallestInfiniteSet", "addBack", "popSmallest", "popSmallest", "popSmallest", "addBack", "popSmallest", "popSmallest", "popSmallest"]
[[], [2], [], [], [], [1], [], [], []]
Output
[null, null, 1, 2, 3, null, 1, 4, 5]

Explanation
SmallestInfiniteSet smallestInfiniteSet = new SmallestInfiniteSet();
smallestInfiniteSet.addBack(2);    // 2 is already in the set, so no change is made.
smallestInfiniteSet.popSmallest(); // return 1, since 1 is the smallest number, and remove it from the set.
smallestInfiniteSet.popSmallest(); // return 2, and remove it from the set.
smallestInfiniteSet.popSmallest(); // return 3, and remove it from the set.
smallestInfiniteSet.addBack(1);    // 1 is added back to the set.
smallestInfiniteSet.popSmallest(); // return 1, since 1 was added back to the set and
                                   // is the smallest number, and remove it from the set.
smallestInfiniteSet.popSmallest(); // return 4, and remove it from the set.
smallestInfiniteSet.popSmallest(); // return 5, and remove it from the set.*/


class MinHeap {
    constructor() {
        this.heap = [];
    }

    push(value) {
        this.heap.push(value);
        this.bubbleUp();
    }

    pop() {
        if (this.heap.length === 0) return null;
        if (this.heap.length === 1) return this.heap.pop();
        const min = this.heap[0];
        this.heap[0] = this.heap.pop();
        this.bubbleDown();
        return min;
    }

    bubbleUp() {
        let index = this.heap.length - 1;
        while (index > 0) {
            const parentIndex = Math.floor((index - 1) / 2);
            if (this.heap[index] < this.heap[parentIndex]) {
                [this.heap[index], this.heap[parentIndex]] = [this.heap[parentIndex], this.heap[index]];
                index = parentIndex;
            } else {
                break;
            }
        }
    }

    bubbleDown() {
        let index = 0;
        while (index < this.heap.length) {
            const leftIndex = 2 * index + 1;
            const rightIndex = 2 * index + 2;
            let smallestIndex = index;
            if (leftIndex < this.heap.length && this.heap[leftIndex] < this.heap[smallestIndex]) {
                smallestIndex = leftIndex;
            }
            if (rightIndex < this.heap.length && this.heap[rightIndex] < this.heap[smallestIndex]) {
                smallestIndex = rightIndex;
            }
            if (smallestIndex !== index) {
                [this.heap[index], this.heap[smallestIndex]] = [this.heap[smallestIndex], this.heap[index]];
                index = smallestIndex;
            } else {
                break;
            }
        }
    }

    size() {
        return this.heap.length;
    }
}

var SmallestInfiniteSet = function () {
    this.heap = new MinHeap();
    this.addedBack = new Set();
    this.smallest = 1;
};

SmallestInfiniteSet.prototype.addBack = function (num) {
    if (num < this.smallest && !this.addedBack.has(num)) {
        this.heap.push(num);
        this.addedBack.add(num);
    }
};

SmallestInfiniteSet.prototype.popSmallest = function () {
    if (this.heap.size() > 0) {
        const smallest = this.heap.pop();
        this.addedBack.delete(smallest);
        return smallest;
    } return this.smallest++;
};