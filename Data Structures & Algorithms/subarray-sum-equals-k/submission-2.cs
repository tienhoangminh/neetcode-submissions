public class Solution {
    // With each start point, how many sub array have sum  = K
    public int SubarraySum(int[] nums, int k) {
        int pointer = 0;
        int counter = 0;
        int sum = 0;
        for(int i = 0; i < nums.Length && pointer < nums.Length; i++){
            
            sum += nums[i];

            if(sum == k){
                counter++;
            }

            if(i == nums.Length - 1){
                pointer++;
                i = pointer - 1; // compensate for the i++ của for
                sum = 0;
            }
        }

        return counter;


        // int left = 0, right = nums.Length - 1;
        // int leftSum = 0; rightSum = 0;
        // int leftSub = 0, rightSub = 0;
        
        // while(left < right){

        // }
    }
}