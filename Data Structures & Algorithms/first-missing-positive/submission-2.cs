public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;
        bool is1Exist = false;
        
        for(int i = 0; i < n; i++){
            if(nums[i] == 1){
                is1Exist = true;
            }
            if(nums[i] < 1 || nums[i] > n){
                nums[i] = 1;
            }
        }

        if(!is1Exist){
            return 1;
        }

        for(int i = 0; i < n; i++){
            int index = Math.Abs(nums[i]) - 1;

            if(nums[index] < 0){
               continue; 
            }

            nums[index] = -Math.Abs(nums[index]);
        }
        
        for(int i = 0; i < n; i++){
            if(nums[i] > 0){
                return i + 1;
            }
        }

        return n+1;

    }
}