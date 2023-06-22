namespace BestTimeBuySellStockTransactionFee
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BestTimeBuySellStockTransactionFee bestTimeBuySellStockTransactionFee = new();
            Console.WriteLine(bestTimeBuySellStockTransactionFee.MaxProfit(new int[] { 1, 3, 2, 8, 4, 9 }, 2));
			Console.WriteLine(bestTimeBuySellStockTransactionFee.MaxProfit(new int[] { 1, 3, 7, 5, 10, 3 }, 3));
		}
	}
}