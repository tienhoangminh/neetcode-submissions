public class Solution {
    // With each start point, how many sub array have sum  = K
    // Store prefix sum and frequency to remove reduce reapeat work
    public int SubarraySum(int[] nums, int k) {
        int counter = 0;
        var prefixCount = new Dictionary<int, int>();
        prefixCount[0] = 1;
        int sum = 0;

        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            int needed = sum - k;

            if(prefixCount.TryGetValue(needed, out int frequency)){
                counter += frequency;
            }

            if(prefixCount.ContainsKey(sum)){
                prefixCount[sum]++;
            }else{
                prefixCount[sum] = 1;
            }
        }

        return counter;

    }
}