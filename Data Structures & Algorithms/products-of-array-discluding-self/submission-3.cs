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
        for(int i = n-1; i >= 0; i--){
            results[i] *= right;
            right *= nums[i];
        }

        return results;

    }
}
