public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n = word1.Length > word2.Length ? word1.Length : word2.Length;
        string result = "";
        for(int i = 0; i < n; i++){
            if(i < word1.Length){
                result += word1[i];
            }

            if(i < word2.Length){
                result += word2[i];
            }
        }

        return result;
    }
}