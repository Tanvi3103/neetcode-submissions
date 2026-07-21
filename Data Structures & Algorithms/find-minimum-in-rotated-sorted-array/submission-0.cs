public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;
        int result = nums[0];

        while (left <= right) {
            if (nums[left] < nums[right]) {
                result = Math.Min(result, nums[left]);
                break;
            }

            int middle = (left+right)/2;//left + (right - left) / 2;

            result = Math.Min(result, nums[middle]);
            if (nums[middle] >= nums[left]) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }
        return result;
    }
}