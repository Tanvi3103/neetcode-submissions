public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length-1;

        while(right>left){
            if(numbers[left]+numbers[right]== target){
                break;
            }
            if(numbers[left]+numbers[right]>target){
                right--;
            }
            else{
                left++;
            }
        }
        return new int[]{left+1, right+1};
    }
}