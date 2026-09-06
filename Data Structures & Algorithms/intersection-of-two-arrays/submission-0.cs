public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> store = new HashSet<int>();
        List<int> ans = new List<int>();
        foreach (int i in nums1){
            store.Add(i);
        }
        foreach (int i in nums2){
            if(store.Contains(i)){
                ans.Add(i);
                store.Remove(i);
            }
        }
        return ans.ToArray();
    }
}