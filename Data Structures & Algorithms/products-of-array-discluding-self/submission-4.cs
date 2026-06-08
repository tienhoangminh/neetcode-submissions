public class Solution {
    // Key idea:
    //
    // For any index i, the answer comes from:
    //
    // - the product of all values before i
    // - the product of all values after i
    //
    // The current value itself is excluded.
    //
    // First, calculate and store the contribution from the left side.
    //
    // After this pass:
    // result[i] = product of all values before i
    //
    // Border case:
    // result[0] = 1 because there are no values before the first element.
    //
    // Then traverse from right to left while maintaining
    // the product of all values after the current index.
    //
    // Border case:
    // right starts at 1 because there are no values after
    // the last element.
    //
    // At each index:
    // answer = left-side contribution * right-side contribution
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        result[0] = 1;
        for(int i = 1; i < n; i++){
            result[i] = result[i-1] * nums[i-1];
        }

        int right = 1;
        for(int i = n-1; i >= 0; i--){
            result[i] *= right;
            right *= nums[i];
        }

        return result;
    }
}
