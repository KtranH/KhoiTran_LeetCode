<?php

/*Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.*/

$prices = [7,1,5,3,6,4];

function solve_best_time_to_buy_and_sell_stock($prices) {
    $min_price = $prices[0];
    $max_profit = 0;
    for ($i = 1; $i < count($prices); $i++) {
        if ($prices[$i] < $min_price) {
            $min_price = $prices[$i];
        } else if ($prices[$i] - $min_price > $max_profit) {
            $max_profit = $prices[$i] - $min_price;
        }
    }
    return $max_profit;
}

echo solve_best_time_to_buy_and_sell_stock($prices);
?>
