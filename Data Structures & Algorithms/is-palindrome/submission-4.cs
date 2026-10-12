
public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;

        while (l < r) {
            bool isAlphanumericL =
                (s[l] >= 'A' && s[l] <= 'Z') ||
                (s[l] >= 'a' && s[l] <= 'z') ||
                (s[l] >= '0' && s[l] <= '9');

            if (!isAlphanumericL) {
                l++;
                continue;
            }

            bool isAlphanumericR =
                (s[r] >= 'A' && s[r] <= 'Z') ||
                (s[r] >= 'a' && s[r] <= 'z') ||
                (s[r] >= '0' && s[r] <= '9');

            if (!isAlphanumericR) {
                r--;
                continue;
            }

            char lValue = s[l];
            char rValue = s[r];

            if (lValue >= 'A' && lValue <= 'Z')
                lValue = (char)(lValue + 32);

            if (rValue >= 'A' && rValue <= 'Z')
                rValue = (char)(rValue + 32);

            if (lValue != rValue) {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }
}
