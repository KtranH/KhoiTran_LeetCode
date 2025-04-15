<?php

/*Example 1:

Input: prices = [1,3,2,8,4,9], fee = 2
Output: 8
Explanation: The maximum profit can be achieved by:
- Buying at prices[0] = 1
- Selling at prices[3] = 8
- Buying at prices[4] = 4
- Selling at prices[5] = 9
The total profit is ((8 - 1) - 2) + ((9 - 4) - 2) = 8.
Example 2:

Input: prices = [1,3,7,5,10,3], fee = 3
Output: 6*/

$prices = [1,3,2,8,4,9];
$fee = 2;

function solve_best_time_to_buy_and_sell_stock_with_transaction_fee($prices, $fee) {
    $n = count($prices);
    $cash = 0;
    $hold = -$prices[0];
    for ($i = 1; $i < $n; $i++)
    {
        $cash = max($cash, $hold + $prices[$i] - $fee);
        $hold = max($hold, $cash - $prices[$i]);
    }
    return $cash;
}

echo solve_best_time_to_buy_and_sell_stock_with_transaction_fee($prices, $fee);