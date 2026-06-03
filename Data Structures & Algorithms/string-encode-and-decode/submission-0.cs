public class Solution {

    // Encode => Encode have to describe for metadata itself 
    // Metadata = string Length in this case
    public string Encode(IList<string> strs) {
        var builder = new StringBuilder();
        foreach(string str in strs){
            builder.Append(str.Length);
            builder.Append("#");
            builder.Append(str);
        }

        return builder.ToString();
    }

    public List<string> Decode(string s) {
        // Decode read metadata before start decode
        // Find Length of each string first
        // Ex: 2#ha10#bababababa3#ddd 
        var results = new List<string>();
        int i = 0,j = 0;

        while(j < s.Length){
            
            while(s[j] != '#'){
                j++;
            }
            // Number of digits that length can take = j - i
            int digit = j - i;
            // Length of current string 
            string length = s.Substring(i, digit);
            int n = int.Parse(length);
            // Decode for current string
            var str = s.Substring(j+1, n);
            results.Add(str);

            // Update pointer for the next string
            int temp = j + n + 1;
            j = temp;
            i = temp;

        }

        return results;

   }
}
