<?php

/*
Example 1:

Input
["RandomizedSet", "insert", "remove", "insert", "getRandom", "remove", "insert", "getRandom"]
[[], [1], [2], [2], [], [1], [2], []]
Output
[null, true, false, true, 2, true, false, 2]

Explanation
RandomizedSet randomizedSet = new RandomizedSet();
randomizedSet.insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
randomizedSet.remove(2); // Returns false as 2 does not exist in the set.
randomizedSet.insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
randomizedSet.getRandom(); // getRandom() should return either 1 or 2 randomly.
randomizedSet.remove(1); // Removes 1 from the set, returns true. Set now contains [2].
randomizedSet.insert(2); // 2 was already in the set, so return false.
randomizedSet.getRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.
*/

class RandomizedSet {
    public $hashmap;
    public $list;
    function __construct() {
        $this->hashmap = [];
        $this->list = [];
    }
    function insert($val) {
        if(in_array($val, $this->list)) {
            return false;
        }
        $this->hashmap[$val] = count($this->list);
        $this->list[] = $val;
        return true;
    }
    function remove($val) {
        if(!in_array($val, $this->list)) {
            return false;
        }
        $index = $this->hashmap[$val];
        $this->hashmap[$this->list[count($this->list) - 1]] = $index;
        $this->list[$index] = $this->list[count($this->list) - 1];
        unset($this->hashmap[$val]);
        array_pop($this->list);
        return true;
    }
    function getRandom() {
        return $this->list[array_rand($this->list)];
    }
}

$randomizedSet = new RandomizedSet();
$randomizedSet->insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
$randomizedSet->remove(2); // Returns false as 2 does not exist in the set.
$randomizedSet->insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
$randomizedSet->getRandom(); // getRandom() should return either 1 or 2 randomly.
$randomizedSet->remove(1); // Removes 1 from the set, returns true. Set now contains [2].
$randomizedSet->insert(2); // 2 was already in the set, so return false.
$randomizedSet->getRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.
