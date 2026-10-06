public class Solution {
    public int MissingNumber(int[] nums) {
        int ans=0;
        for(int i =0; i<nums.Length; i++){
           ans = ans^nums[i];
           ans = ans^(i+1);
        }
        return ans;
    }
}