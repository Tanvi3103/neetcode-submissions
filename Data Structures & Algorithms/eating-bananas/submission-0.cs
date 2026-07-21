public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int result = right;

        while(left<=right){
            int k = (left+right)/2;
            long time = 0;
            foreach(int p in piles){
                time = time + (int)Math.Ceiling((double)p/k);
            }
            if(time<=h){
                result = k;
                right = k-1;
            }
            else{
                left = k+1;
            }
        }
        return result;
    }
}
