public class Solution {
    /*
     * Goal:
     * Find the smallest positive integer that does not exist in nums.
     *
     * Key constraints:
     * - Time O(n) => We cannot repeatedly scan the array (no nested loops).
     * - Space O(1) => We cannot use a HashSet/Dictionary.
     *                Instead, reuse nums itself to store "seen" information.
     *
     * Key idea:
     * - We only care about numbers from 1 to n.
     * - Map each number to an array index:
     *
     *       number 1 -> index 0
     *       number 2 -> index 1
     *       number 3 -> index 2
     *       ...
     *       number n -> index n - 1
     *
     * - Use the sign of nums[index] as a marker:
     *       positive -> number has NOT been seen
     *       negative -> number HAS been seen
     *
     * Why normalize invalid numbers?
     * - Numbers <= 0 or > n cannot be the answer.
     * - We replace them with 1 so every value stays in the valid range [1, n].
     *
     * Special case:
     * - We need to know whether 1 actually exists BEFORE normalization.
     * - If 1 does not exist, the answer is immediately 1.
     * - After confirming 1 exists, replacing invalid values with 1 is safe.
     */

    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;
        bool is1Exist = false;

        // Step 1: Check whether 1 exists and normalize useless values.
        for(int i = 0; i < n; i++){
            int num = nums[i];

            if(num == 1){
                is1Exist = true;
            }

            // Only numbers in [1, n] can affect the answer.
            if(num <= 0 || num > n){
                nums[i] = 1;
            }
        }

        if(!is1Exist){
            return 1;
        }

        // Step 2: Mark every number that exists.
        // number x -> index x - 1
        // Negative value means "x exists".
        for(int i = 0; i < n; i++){
            int index = Math.Abs(nums[i]) - 1;
            nums[index] = -Math.Abs(nums[index]);
        }

        // Step 3: The first positive position is the missing number.
        // index i -> number i + 1
        for(int i = 0; i < n; i++){
            if(nums[i] > 0){
                return i + 1;
            }
        }

        // Every number from 1 to n exists.
        // Therefore the answer is n + 1.
        return n + 1;
    }
}