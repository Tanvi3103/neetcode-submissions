public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,int> seenBefore = new Dictionary<int,int>();

        for(int i=0; i<nums.Length; i++){
            if(seenBefore.ContainsKey(nums[i]) 
            && Math.Abs(i - seenBefore[nums[i]]) <= k){
                return true;
            }
            else{
                seenBefore[nums[i]]= i;
            }
        }
        return false;
    }
}