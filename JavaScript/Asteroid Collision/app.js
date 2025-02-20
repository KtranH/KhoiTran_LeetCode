const asteroids = [5,10,-5]

function solve_asteroid_collision(asteroids)
{
    let stack = [];
    for (let i = 0; i < asteroids.length; i++)
    {
        if(asteroids[i] > 0) 
        {
            stack.push(asteroids[i]);
        }
        else
        {
            while(stack.length > 0 && stack[stack.length - 1] > 0 && stack[stack.length - 1] < -asteroids[i]) stack.pop();
            if(stack.length === 0 || stack[stack.length - 1] < 0) stack.push(asteroids[i]);
            else if(stack[stack.length - 1] === -asteroids[i]) stack.pop();
        }
    }
    return stack;
}

console.log(solve_asteroid_collision(asteroids)); // Output: [5, 10]