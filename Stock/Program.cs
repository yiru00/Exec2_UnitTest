using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispan.TainwanStockUtilities;

namespace Stock
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//取得使用者輸入字串
			Console.WriteLine("請輸入時間:年/月/日 時:分:秒");
			string input = Console.ReadLine();
			var obj = new TaiwanStockUtilities();
			


			//判斷格式
			DateTime inputDateTime = DateTime.Today;
			try
			{
				inputDateTime= obj.IsDateTime(input);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}

			//判斷是否在股票交易時間
			bool result=false;
			try
			{
				result = obj.IsTradingTime(inputDateTime);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}

			//結果
			//Console.WriteLine("在營業時間內");


		}
	}
}
