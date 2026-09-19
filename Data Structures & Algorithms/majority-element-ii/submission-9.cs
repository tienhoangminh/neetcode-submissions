public class Solution
{
    // Refactor by GPT
    public List<int> MajorityElement(int[] nums)
    {
        int cand1 = 0, cand2 = 0;
        int count1 = 0, count2 = 0;

        // Find at most two candidates
        foreach (int num in nums)
        {
            if (count1 > 0 && num == cand1)
            {
                count1++;
            }
            else if (count2 > 0 && num == cand2)
            {
                count2++;
            }
            else if (count1 == 0)
            {
                cand1 = num;
                count1 = 1;
            }
            else if (count2 == 0)
            {
                cand2 = num;
                count2 = 1;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        // Verify actual frequencies
        count1 = 0;
        count2 = 0;

        foreach (int num in nums)
        {
            if (num == cand1)
                count1++;

            if (num == cand2)
                count2++;
        }

        var results = new List<int>();

        if (count1 > nums.Length / 3)
            results.Add(cand1);

        if (cand1 != cand2 && count2 > nums.Length / 3)
            results.Add(cand2);

        return results;
    }
}