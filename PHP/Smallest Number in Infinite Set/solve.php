<?php

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

function solve_smallest_number_in_infinite_set($nums, $k)
{
    $min_heap = new SplMinHeap();
    $next_smallest = 1;
    $added_back = [];
}

function pop_smallest($min_heap, $next_smallest, &$added_back)
{
    if ($min_heap->isEmpty())
    {
        return $next_smallest++;
    }
    $smallest = $min_heap->extract();
    unset($added_back[$smallest]);
    return $smallest;
}

function add_back($min_heap, $next_smallest, &$added_back, $num)
{
    if ($num < $next_smallest && !isset($added_back[$num]))
    {
        $min_heap->insert($num);
        $added_back[$num] = true;
    }
}