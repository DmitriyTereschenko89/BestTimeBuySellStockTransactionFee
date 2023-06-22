namespace BestTimeBuySellStockTransactionFee
{
	internal class BestTimeBuySellStockTransactionFee
	{
		public int MaxProfit(int[] prices, int fee)
		{
			int n = prices.Length;
			int[] free = new int[n];
			int[] hold = new int[n];
			hold[0] = -prices[0];
			for (int i = 1; i < n; ++i)
			{
				hold[i] = Math.Max(hold[i - 1], free[i - 1] - prices[i]);
				free[i] = Math.Max(free[i - 1], hold[i - 1] + prices[i] - fee);
			}
			return free[n - 1];
		}
	}
}
