public class Solution
{
    // Treat the price changes between consecutive days as edges.
    // Collect every positive edge and ignore every non-positive edge.
    public int MaxProfit(int[] prices)
    {
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            int edge = prices[i] - prices[i - 1];

            if (edge > 0)
            {
                profit += edge;
            }
        }

        return profit;
    }
}