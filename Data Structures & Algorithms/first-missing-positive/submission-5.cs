public class Solution {
    public int FirstMissingPositive(int[] nums) {
        bool isOneExist = false;
        int n = nums.Length;

        for(int i = 0; i < n; i++){
            if(nums[i] == 1){
                isOneExist = true;
            }

            // Normalize invalid values to 1 because only values from 1 to n matter.
            if(nums[i] <= 0 || nums[i] > n){
                nums[i] = 1;
            }
        }

        // If 1 does not exist, it is immediately the first missing positive.
        if(!isOneExist){
            return 1;
        }

        for(int i = 0; i < n; i++){
            // Map value to its corresponding index:
            // value = index + 1 => index = value - 1.
            int index = Math.Abs(nums[i]) - 1;

            // Mark the value represented by this index as existing.
            // Keep the absolute value at the target index unchanged;
            // only change its sign to negative as a marker.
            nums[index] = -Math.Abs(nums[index]);
        }

        for(int i = 0; i < n; i++){
            // The first positive value means its corresponding number (i + 1) is missing.
            if(nums[i] > 0){
                return i + 1;
            }
        }

        // All values from 1 to n exist, so the first missing positive is n + 1.
        return n + 1;
    }
}