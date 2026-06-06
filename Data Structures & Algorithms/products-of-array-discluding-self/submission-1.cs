public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var results = new int[n];
        var right = new int[n];
        //let results store value for left side first
        results[0] = 1;
        right[n-1] = 1;

        for(int i = 1; i < n; i++){
            results[i] = results[i-1] * nums[i-1];
        }

        for(int i = n-2; i >= 0; i--){
            right[i] = right[i+1] * nums[i+1];
        }

        for(int k = 0; k < n; k++){
            results[k] *= right[k];
        }

        return results;

    }
}
