public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length < 2) return 0;

        int left = 0; // Buy pointer
        int right = 1; // Sell pointer
        int maxProfit = 0;

        while (right < prices.Length) {
            // If the price at 'right' is higher than 'left', we have a potential profit
            if (prices[left] < prices[right]) {
                int currentProfit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, currentProfit);
            } 
            else {
                // If we found a price lower than our 'left', 
                // move 'left' to this new minimum buy price.
                left = right;
            }
            // Always move the sell pointer forward
            right++;
        }

        return maxProfit;
    }
}