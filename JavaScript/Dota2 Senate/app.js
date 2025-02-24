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

const senate = "RDD";

function solve_dota2_senate(senate)
{
    let queue_radiant = [];
    let queue_dire = [];
    let n = senate.length;
    for (let i = 0; i < n; i++)
    {
        if (senate[i] === 'R') queue_radiant.push(i);
        else queue_dire.push(i);
    }

    while (queue_radiant.length > 0 && queue_dire.length > 0)
    {
        let radiant_index = queue_radiant.shift();
        let dire_index = queue_dire.shift();

        if (radiant_index < dire_index)
        {
            queue_radiant.push(radiant_index + n);
        }
        else
        {
            queue_dire.push(dire_index + n);
        }
    }
    return queue_radiant.length > 0 ? "Radiant" : "Dire";
}

console.log(solve_dota2_senates(senate));