public class Solution {
    public int LongestConsecutive(int[] nums) {
        //convert nums to HashSet
        //Find all num that possible to start a sequenc => if num-1 == NOTFOUND => num is a star num
        //Loop through hashset to fin longest sequence

        var sets = nums.ToHashSet();
        var starts = new List<int>();
        foreach(int num in sets){
            if(!sets.Contains(num-1)){
                starts.Add(num);
            }
        }

        int max = 0;
        // foreach(int start in starts){
        //     int longest = 1;
        //     for(int i = 1; i < nums.Length; i++){
        //         if(sets.Contains(start + i)){
        //             longest++;
        //         }else{
        //             break;
        //         }
        //     }

        //     if(longest > max){
        //         max = longest;
        //     }
        // }

        foreach(int start in starts){
            int longest = 1;
            int current = start;

            while(sets.Contains(current+1)){
                longest++;
                current++;
            }

            if(longest > max){
                max = longest;
            }
        }

        return max;
    }
}
