<?php
/*Example 1:

Input: senate = "RD"
Output: "Radiant"
Explanation: 
The first senator comes from Radiant and he can just ban the next senator's right in round 1. 
And the second senator can't exercise any rights anymore since his right has been banned. 
And in round 2, the first senator can just announce the victory since he is the only guy in the senate who can vote.
Example 2:

Input: senate = "RDD"
Output: "Dire"
Explanation: 
The first senator comes from Radiant and he can just ban the next senator's right in round 1. 
And the second senator can't exercise any rights anymore since his right has been banned. 
And the third senator comes from Dire and he can ban the first senator's right in round 1. 
And in round 2, the third senator can just announce the victory since he is the only guy in the senate who can vote.*/


$senate = "RDD";

function solve_dota2_senate($senate)
{
    $queue_radiant = new SplQueue();
    $queue_dire = new SplQueue();
    $n = strlen($senate);

    for($i = 0; $i < $n; $i++)
    {
        if($senate[$i] == 'R')
            $queue_radiant->enqueue($i);
        else
            $queue_dire->enqueue($i);
    }
    
    while(!$queue_radiant->isEmpty() && !$queue_dire->isEmpty())
    {
        $r_index = $queue_radiant->dequeue();
        $d_index = $queue_dire->dequeue();

        if($d_index < $r_index)
        {
           $queue_dire->enqueue($d_index + $n);
        }
        else
        {
            $queue_radiant->enqueue($r_index + $n);
        }
    }
    return $queue_radiant->isEmpty() ? "Dire" : "Radiant";
}

echo solve_dota2_senate($senate);