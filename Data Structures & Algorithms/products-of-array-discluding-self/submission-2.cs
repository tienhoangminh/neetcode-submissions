public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var results = new int[n];
        //let results store value for left side first
        results[0] = 1;

        for(int i = 1; i < n; i++){
            results[i] = results[i-1] * nums[i-1];
        }

        int right = 1;
        for(int i = n-2; i >= 0; i--){
            right *= nums[i+1];
            results[i] *= right;
        }

        return results;

    }
}
