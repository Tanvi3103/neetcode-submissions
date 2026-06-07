public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> SeenBefore = new HashSet<int>();
        foreach(int i in nums){

            if(SeenBefore.Contains(i)){
                return true;
            }
            SeenBefore.Add(i);
        }
        return false;
    } 
}