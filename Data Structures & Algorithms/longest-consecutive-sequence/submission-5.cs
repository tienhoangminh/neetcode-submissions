public class Solution {
    //1. Find all number that can start a consecutive sequence 
    //=> where num-1 == NOTFOUND in nums => num can start a consecutive sequence
    //2. For each start number 
    //=> check if next item in sequence exist in nums 
    //=> if exist then increse to next consecutive item until item not exist in nums
    //=> get length of current sequence => if it > legnth of previous sequence => max = current legnth
    //3. Return max
    //Note: Because (1) and (2) need to find an item by value in an sequence
    //=> Should convert nums to HashSet to take advantage O(1)
    public int LongestConsecutive(int[] nums) {
        
        var hashset = nums.ToHashSet();
        int max = 0;
        foreach(int item in hashset){
            int current = item;
            if(hashset.Contains(current - 1)){
                continue;
            }

            int length = 1;
            while(hashset.Contains(current + 1)){
                current++;
                length++;
            }

            max = length > max ? length : max;
        }

        return max;
    }
}
