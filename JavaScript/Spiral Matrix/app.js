const matrix = [[1,2,3],[4,5,6],[7,8,9]]

/*Example 1:


Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]
Example 2:


Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]*/

function solve_spiral_matrix(matrix){
    let left = 0
    let right = matrix[0].length - 1
    let top = 0
    let bottom = matrix.length - 1
    let result = []
    while(left <= right && top <= bottom){
        for(let i = left; i <= right; i++){
            result.push(matrix[top][i])
        }
        top++
        for(let i = top; i <= bottom; i++){
            result.push(matrix[i][right])
        }
        right--
        if(top <= bottom){
            for(let i = right; i >= left; i--){
                result.push(matrix[bottom][i])
            }
            bottom--
        }
        if(left <= right){
            for(let i = bottom; i >= top; i--){
                result.push(matrix[i][left])
            }
            left++
        }
    }
    return result
}

console.log(solve_spiral_matrix(matrix))