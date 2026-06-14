public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int [] result = new int[nums.Length];
        int pre = 1; 
        int post = 1;

        for(int i= 0 ; i <nums.Length; i++){
            result[i] = pre;
            pre = pre*nums[i];            
        }
        for(int i=nums.Length-1 ; i >=0; i--){
            result[i] = result[i]*post;
            post = post*nums[i];            
        }

        return result;

    }
}
