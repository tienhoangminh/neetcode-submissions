public class Solution {
    public int MajorityElement(int[] nums) {
        int res = 0,count = 0;
        foreach(int i in nums){
            if(count == 0){
                res = i;
            }
            
            if(res == i){
                count++;
            }else{
                count--;
            }
        }

        return res;
    }
}