
/*Example 1:

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
randomizedSet.getRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.*/


var RandomizedSet = function() {
    this.hashmap = {};
    this.list = [];
};

RandomizedSet.prototype.insert = function(val) {
    if(val in this.hashmap) {
        return false;
    }
    this.hashmap[val] = this.list.length;
    this.list.push(val);
    return true;
};

RandomizedSet.prototype.remove = function(val) {
    if(!(val in this.hashmap)) {
        return false;
    }
    let index = this.hashmap[val];
    let lastElement = this.list[this.list.length - 1];
    this.list[index] = lastElement;
    this.hashmap[lastElement] = index;
    this.list.pop();
    delete this.hashmap[val];
    return true;
};

RandomizedSet.prototype.getRandom = function() {
    return this.list[Math.floor(Math.random() * this.list.length)];
};