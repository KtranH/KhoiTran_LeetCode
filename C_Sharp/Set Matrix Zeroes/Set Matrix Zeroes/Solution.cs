using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Matrix_Zeroes
{
    internal class Solution
    {
        public void solve_set_matrix_zeroes(int[][] matrix) {
            int n = matrix.Length;
            int m = matrix[0].Length;

            bool firstRow = false;
            bool firstCol = false;

            for(int j = 0; j < m; j++) {
               if(matrix[0][j] == 0) {
                   firstRow = true;
                   break;
               }
            }

            for(int i = 0; i < n; i++) {
                if(matrix[i][0] == 0) {
                    firstCol = true;
                    break;
                }
            }

            for(int i = 1; i < n; i++)
            {
                for(int j = 1; j < m; j++)
                {
                    if(matrix[i][j] == 0) {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for(int i = 1; i < n; i++) {
                for(int j = 1; j < m; j++) {
                    if(matrix[i][0] == 0 || matrix[0][j] == 0) {
                        matrix[i][j] = 0;
                    }
                }
            }

            if(firstRow) {
                for(int j = 0; j < m; j++) {
                    matrix[0][j] = 0;
                }
            }
            if(firstCol) {
                for(int i = 0; i < n; i++) {
                    matrix[i][0] = 0;
                }
            }
        }
    }
}
