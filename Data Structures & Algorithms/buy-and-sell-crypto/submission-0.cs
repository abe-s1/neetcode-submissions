public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        var max = prices[0];
        var min = prices[0];

        for (int i = 1; i < prices.Length; i++) {
            var current = prices[i];

            if (current > max) {
                max = current;
                var currentProfit = max - min;
                profit = Math.Max(currentProfit, profit);
            } else if (current < min) {
                min = current;
                max = current;
            }
        }

        return profit;
    }
}
