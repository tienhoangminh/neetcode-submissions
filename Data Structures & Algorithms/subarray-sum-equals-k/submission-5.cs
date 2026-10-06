public class Solution {
    public int SubarraySum(int[] nums, int k) {
        //caluculate prefix-sum and store its frequenly in hashmap
        var dic = new Dictionary<int, int>();
        dic[0] = 1;
        int sum = 0, counter = 0;
        //2,1,2,4
        foreach(int num in nums){
            sum += num;
            int needed = sum - k;

            if(dic.ContainsKey(needed)){
                counter += dic[needed];
            }

            if(dic.ContainsKey(sum)){
                dic[sum] = dic[sum] + 1;
            }else{
                dic[sum] = 1;
            }
        }

        return counter;
    }
}