public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var results = new int[n];
        // (1) Brute Force O(n2)
        // for(int i = 0; i < n; i++){
        //     int value = 1;
        //     for(int j = 0; j < n; j++){
        //         if(i == j){
        //             continue;
        //         }

        //         value *= nums[j];
        //     }

        //     results[i] = value;
        // }

        // (2) Use Division operation O(n)
        // int value = 1;
        // int zero = 0;
        // for(int i = 0; i < n; i++){
        //     if(nums[i] == 0){
        //         zero++;
        //         continue;
        //     }
        //     value *= nums[i];
        // }

        // if(zero > 1){
        //     return results;
        // }

        // for(int i = 0; i < n; i++){
        //     if(zero == 1){
        //         if(nums[i] == 0){
        //             results[i] = value;
        //         }else{
        //             results[i] = 0;
        //         }
        //     }else{
        //         results[i] = value/nums[i];
        //     }
        // }

        // (3) Prefix & Suffix
        var left = new int[n];
        var right = new int[n];
        left[0] = 1;
        left[1] = nums[0];
        right[n-1] = 1;
        right[n-2] = nums[n-1];
        int i = 2, j = n - 3;
        while(i < n || j > 0){
            left[i] = left[i - 1] * nums[i - 1];
            i++;
            right[j] = right[j+1] * nums[j+1];
            j--;
        }

        for(int k = 0; k < n; k++){
            results[k] = left[k] * right[k];
        }

        return results;

    }
}
