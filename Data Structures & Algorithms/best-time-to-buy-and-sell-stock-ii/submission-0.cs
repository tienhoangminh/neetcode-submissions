public class Solution {
    //if num < num+1 => buy => sell
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int holding = prices[0];

        for(int i = 0; i < prices.Length - 1; i++){
            if(prices[i] < prices[i+1]){
                //Buy
                holding = prices[i];
                profit += prices[i+1] - holding;
            }
        }

        return profit;
    }
}