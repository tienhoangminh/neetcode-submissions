public class Solution {
    public int LongestConsecutive(int[] nums) {
        //convert nums to HashSet
        //Find all num that possible to start a sequenc => if num-1 == NOTFOUND => num is a star num
        //Loop through hashset to fin longest sequence

        var sets = nums.ToHashSet();
        int max = 0;

        foreach(int num in sets){
            if(sets.Contains(num-1)){
                continue;
            }

            int current = num;
            int longest = 1;

            while(sets.Contains(current+1)){
                current++;
                longest++;
            }

            if(longest > max){
                max = longest;
            }
        }

        return max;
    }
}
