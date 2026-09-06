public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int x= 0;
        foreach (int i in nums){
            if(i!=val){
               
                nums[x]= i;
                 x++;
            }
        }
        return x;
    }
}