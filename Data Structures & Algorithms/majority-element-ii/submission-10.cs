public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int cand1 = 0, cand2 = 0;
        int counter1 = 0 , counter2 = 0;

        foreach(int num in nums){
            if(num == cand1){
                counter1++;
            }else if(num == cand2){
                counter2++;
            }else if(counter1 == 0){
                cand1 = num;
                counter1 = 1;
            }else if(counter2 == 0){
                cand2 = num;
                counter2 = 1;
            }else{
                counter1--;
                counter2--;
            }
        }
        
        counter1 = 0;
        counter2 = 0;
        foreach(int num in nums){
            if(cand1 == num){
                counter1++;
            }else if(cand2 == num){
                counter2++;
            }
        }

        var result = new List<int>();

        if(counter1 > nums.Length/3)
            result.Add(cand1);
        if(counter2 > nums.Length/3)
            result.Add(cand2);

        return result;
    }
}