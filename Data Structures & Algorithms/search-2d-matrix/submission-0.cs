public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int left = 0;
        int right = rows*cols-1;
        while (left<=right)
        {
            int middle = left + ((right-left)/2);
            int x = middle/cols; int y = middle%cols;
            if(matrix[x][y]==target){ return true;}
            else if (matrix[x][y]<target){left=middle+1;}
            else {right=middle-1;}


        }
        return false;
    }
}

