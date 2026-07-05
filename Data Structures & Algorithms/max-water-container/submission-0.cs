public class Solution {
    public int MaxArea(int[] heights) {
        int max_area = 0;
        int l= 0;
        int r = heights.Length-1;

        while(l<r){
            int area = (r-l)*Math.Min(heights[l],heights[r]);
            max_area = Math.Max(area, max_area);

            if(heights[l]<=heights[r]){
                l++;
            }
            else{
                r--;
            }


        }

        return max_area;
    }
}
