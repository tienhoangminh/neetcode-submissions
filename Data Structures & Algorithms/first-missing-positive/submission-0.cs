public class Solution {
    public int FirstMissingPositive(int[] nums) {
        //Convert to an HashSet then Set default smallest number = 1, then check if it exist in nums
        //if NO then return if YES then plus 1 then check again

        var set = new HashSet<int>();

        foreach(int num in nums){
            if(num <= 0){
                continue;
            }

            set.Add(num);
        }

        int n = set.Count;
        int min = 1;

        for(int i = 0; i < n; i++){
            if(set.Contains(min)){
                min++;
            }else{
                return min;
            }
        }

        return min;

    }
}