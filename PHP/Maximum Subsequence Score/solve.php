<?php

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

class Solution {
    private function heapify(&$nums, $n, $i) {
        $smallest = $i;
        $left = 2 * $i + 1;
        $right = 2 * $i + 2;

        if ($left < $n && $nums[$left] < $nums[$smallest]) {
            $smallest = $left;
        }
        if ($right < $n && $nums[$right] < $nums[$smallest]) {
            $smallest = $right;
        }
        if ($smallest != $i) {
            list($nums[$i], $nums[$smallest]) = array($nums[$smallest], $nums[$i]);
            $this->heapify($nums, $n, $smallest);
        }
    }

    private function insert(&$nums, $val) {
        $nums[] = $val;
        $i = count($nums) - 1;
        while ($i > 0 && $nums[$i] < $nums[intval(($i - 1) / 2)]) {
            list($nums[$i], $nums[intval(($i - 1) / 2)]) = array($nums[intval(($i - 1) / 2)], $nums[$i]);
            $i = intval(($i - 1) / 2);
        }
    }

    private function peekMin($nums) {
        return $nums[0];
    }

    private function popMin(&$nums) {
        if (count($nums) === 0) throw new Exception('Heap is empty');

        $min = $nums[0];
        $nums[0] = array_pop($nums);
        $this->heapify($nums, count($nums), 0);

        return $min;
    }

    function maxScore($nums1, $nums2, $k) {
        if ($k == 1) {
            $maxResult = 0;
            for ($i = 0; $i < count($nums1); $i++) {
                $maxResult = max($maxResult, $nums1[$i] * $nums2[$i]);
            }
            return $maxResult;
        }

        $sortedIndices = range(0, count($nums2) - 1);
        array_multisort(array_map(fn($i) => $nums2[$i], $sortedIndices), SORT_DESC, $sortedIndices);

        $heap = [];
        $sumSelected = 0;
        $maxResult = 0;

        foreach ($sortedIndices as $index) {
            if (count($heap) < $k) {
                $this->insert($heap, $nums1[$index]);
                $sumSelected += $nums1[$index];
            } else {
                if ($nums1[$index] > $this->peekMin($heap)) {
                    $sumSelected += $nums1[$index] - $this->popMin($heap);
                    $this->insert($heap, $nums1[$index]);
                }
            }

            if (count($heap) === $k) {
                $maxResult = max($maxResult, $sumSelected * $nums2[$index]);
            }
        }

        return $maxResult;
    }
}

// Test case
$solution = new Solution();
$nums1 = [1, 6, 6, 8];
$nums2 = [3, 0, 7, 7];
$k = 1;
echo $solution->maxScore($nums1, $nums2, $k);
?>
