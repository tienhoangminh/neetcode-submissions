public class Solution {
    public int MajorityElement(int[] nums) {
        var dictionary = new Dictionary<int, int>();

        foreach(int num in nums){
            if(dictionary.ContainsKey(num)){
                dictionary[num]++;
            }else{
                dictionary.Add(num, 1);
            }
        }

        var major = nums.Length / 2;
        foreach(var item in dictionary){
            if(item.Value > major){
                return item.Key;
            }
        }

        return 0;
    }
}