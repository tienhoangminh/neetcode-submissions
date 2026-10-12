public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;

        

        while(l < r){
            bool isAlphanumericL = (s[l] >= 'A' && s[l] <= 'Z') || (s[l] >= 'a' && s[l] <= 'z') || (s[l] >= '0' && s[l] <= '9');
            if(!isAlphanumericL){
                l++;
                continue;
            }

            bool isAlphanumericR = (s[r] >= 'A' && s[r] <= 'Z') || (s[r] >= 'a' && s[r] <= 'z') || (s[r] >= '0' && s[r] <= '9');
            if(!isAlphanumericR){
                r--;
                continue;
            }

            var lValue = s[l] < 'a' ? (char)(s[l] + 32) : s[l];
            var rValue = s[r] < 'a' ? (char)(s[r] + 32) : s[r];

            if(lValue != rValue){
                return false;
            }

            l++;
            r--;
        }

        return true;
    }
}
