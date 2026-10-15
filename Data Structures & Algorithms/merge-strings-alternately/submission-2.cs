public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var result = new char[word1.Length + word2.Length];
        int p0 = 0, p1 = 0, i = 0;

        while(i < result.Length){
            if(p0 < word1.Length){
                result[i] = word1[p0];
                p0++;
                i++;
            }

            if(p1 < word2.Length){
                result[i] = word2[p1];
                p1++;
                i++;
            }
        }

        return new string(result);

    }
}