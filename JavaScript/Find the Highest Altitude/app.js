const gain = [-5, 1, 5, 0, -7];

function solve_find_the_highest_altitude(gain)
{
    let max_altitude = 0;
    let prelix_sum = 0;
    let current_altitude = 0;
    gain.unshift(0);
    
    for (let i = 0; i <= gain.length; i++)
    {
        prelix_sum += gain[i];
        current_altitude = prelix_sum;
        if (current_altitude > max_altitude) max_altitude = current_altitude;
    }

    return max_altitude;
}

console.log(solve_find_the_highest_altitude(gain)); 