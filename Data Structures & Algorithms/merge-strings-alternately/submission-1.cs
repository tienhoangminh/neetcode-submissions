public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n = word1.Length + word2.Length;
        char[] result = new char[n];
        
        int i = 0, p1 = 0, p2 = 0;
        while (p1 < word1.Length || p2 < word2.Length) {
            if (p1 < word1.Length) {
                result[i++] = word1[p1++];
            }
            if (p2 < word2.Length) {
                result[i++] = word2[p2++];
            }
        }
        
        return new string(result);
    }
}