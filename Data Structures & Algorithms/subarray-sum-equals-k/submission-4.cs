public class Solution {
    public int SubarraySum(int[] nums, int k) {
        //Calculate prefix Sum and store frequency in HashMap
        var prefixCount = new Dictionary<int, int>();
        prefixCount[0] = 1;
        int sum = 0, counter = 0;

        foreach(int num in nums){
            sum += num;
            int needed = sum - k;

            if(prefixCount.TryGetValue(needed, out int frequency)){
                counter += frequency;
            }

            if(prefixCount.ContainsKey(sum)){
                prefixCount[sum] = prefixCount[sum] + 1;
            }else{
                prefixCount[sum] = 1;
            }
        }

        return counter;
    }
}