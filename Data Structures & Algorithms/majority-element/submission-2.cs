public class Solution {
    public int MajorityElement(int[] nums) {
        int major = 0;
        int counter = 0;

        foreach(int num in nums){
            if(major == num){
                counter++;
            }else if(counter == 0){
                major = num;
                counter = 1;
            }else{
                counter--;
            }
        }

        return major;
    }
}