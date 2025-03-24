<?php

/*Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4   
*/

$nums = [3,2,1,5,6,4];
$k = 2;

function heapify($nums, $n, $i)
{
    $smallest = $i;
    $left = 2 * $i + 1;
    $right = 2 * $i + 2;
    if ($left < $n && $nums[$left] < $nums[$smallest])
    {
        $smallest = $left;
    }
    if ($right < $n && $nums[$right] < $nums[$smallest])
    {
        $smallest = $right;
    }
    if ($smallest != $i)
    {
        $swap = $nums[$i];
        $nums[$i] = $nums[$smallest];
        $nums[$smallest] = $swap;
        heapify($nums, $n, $smallest);
    }
}

function solve_kth_largest_element_in_an_array($nums, $k)
{
    $heap = [];
    for ($i = 0; $i < $k; $i++)
    {
        array_push($heap, $nums[$i]);
    }
    for ($i = floor($k / 2) - 1; $i >= 0; $i--)
    {
        heapify($heap, $k, $i);
    }
    for ($i = $k; $i < count($nums); $i++)
    {
        if ($nums[$i] > $heap[0])
        {
            $heap[0] = $nums[$i];
            heapify($heap, $k, 0);
        }
    }
    return $heap[0];
}

echo solve_kth_largest_element_in_an_array($nums, $k);