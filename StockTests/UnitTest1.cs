using Ispan.TainwanStockUtilities;

namespace StockTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		
		[TestCase("2022/10/27 13:0:0", true)]
		public void Test1_正確時間(string input,bool istrue)
		{
			//取得使用者輸入字串
			Console.WriteLine("請輸入時間:年/月/日 時:分:秒");
			string _input = input;
			var obj = new TaiwanStockUtilities();



			//判斷格式
			DateTime inputDateTime = DateTime.Today;
			try
			{
				inputDateTime = obj.IsDateTime(input);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}

			//判斷是否在股票交易時間
			bool result = false;
			try
			{
				result = obj.IsTradingTime(inputDateTime);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
		}


		[TestCase("2022/10/27 13:31:0", true)]
		public void Test2_星期對時間錯(string input, bool istrue)
		{
			//取得使用者輸入字串
			Console.WriteLine("請輸入時間:年/月/日 時:分:秒");
			string _input = input;
			var obj = new TaiwanStockUtilities();



			//判斷格式
			DateTime inputDateTime = DateTime.Today;
			try
			{
				inputDateTime = obj.IsDateTime(input);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}

			//判斷是否在股票交易時間
			bool result = false;
			try
			{
				result = obj.IsTradingTime(inputDateTime);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
		}


		[TestCase("2022/10/29 13:0:0:0", true)]
		public void Test3_星期錯時間對(string input, bool istrue)
		{
			//取得使用者輸入字串
			Console.WriteLine("請輸入時間:年/月/日 時:分:秒");
			string _input = input;
			var obj = new TaiwanStockUtilities();



			//判斷格式
			DateTime inputDateTime = DateTime.Today;
			try
			{
				inputDateTime = obj.IsDateTime(input);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}

			//判斷是否在股票交易時間
			bool result = false;
			try
			{
				result = obj.IsTradingTime(inputDateTime);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
		}


		[TestCase("2022/10/29 8:0:0:0", true)]
		public void Test4_星期錯時間錯(string input, bool istrue)
		{
			//取得使用者輸入字串
			Console.WriteLine("請輸入時間:年/月/日 時:分:秒");
			string _input = input;
			var obj = new TaiwanStockUtilities();



			//判斷格式
			DateTime inputDateTime = DateTime.Today;
			try
			{
				inputDateTime = obj.IsDateTime(input);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}

			//判斷是否在股票交易時間
			bool result = false;
			try
			{
				result = obj.IsTradingTime(inputDateTime);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
		}
	}
}