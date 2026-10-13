public class Solution {
    //I use two pointers to compare characters from both ends. If the characters match, I move both pointers inward. 
    //If they don't match, I have two possible choices: skip the left character or skip the right character. 
    //I check whether either remaining substring is a palindrome using a helper function. 
    //Since I only perform a constant number of linear scans, the time complexity is O(n), and the auxiliary space complexity is O(1).
    public bool ValidPalindrome(string s) {
        int l = 0, r = s.Length - 1;

        while(l < r){

            if(s[l] != s[r]){
                return IsPalindrome(s, l + 1, r) || IsPalindrome(s, l, r - 1);
            }

            l++;
            r--;
        }

        return true;
    }

    public bool IsPalindrome(string s, int left, int right){
        while(left < right){

            if(s[left] != s[right]){
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}