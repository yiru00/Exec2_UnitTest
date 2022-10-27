using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ispan.TainwanStockUtilities
{
	public class TaiwanStockUtilities
	{
		/// <summary>
		/// 判斷是否在股票交易時間
		/// </summary>
		/// <param name="dt">使用者輸入的日期</param>
		/// <returns>滿足兩條件回傳true</returns>
		/// <exception cref="Exception"></exception>
		public bool IsTradingTime(DateTime dt)
		{   
			//日期必須在星期一~星期五
			//時間必須介於9:00~13:30
			int week = Convert.ToInt32(dt.DayOfWeek);
			int hours= Convert.ToInt32(dt.Hour)*100;
			int minutes=Convert.ToInt32(dt.Minute);
			int time = hours + minutes;
			if (week>=1&&week<=5)
			{
				if (time>=900&&time>=1330)
				{
					return true;
				}
				else
				{
					throw new Exception("時間必須介於9:00~13:30");
				}
			}
			else
			{
				throw new Exception("日期必須在星期一~星期五");
			}
		}


		/// <summary>
		/// 判斷輸入日期格式
		/// </summary>
		/// <param name="input">使用者輸入的字串</param>
		/// <returns>傳回DateTime型別的輸入內容</returns>
		/// <exception cref="Exception"></exception>
		public DateTime IsDateTime(string input) 
		{
			bool isTrue = DateTime.TryParse(input, out DateTime inputDateTime);
			return (isTrue == false) ? throw new Exception("請輸入正確格式") : inputDateTime;
			
		}

		

	}
}
