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
		public void Test1_���T�ɶ�(string input,bool istrue)
		{
			//���o�ϥΪ̿�J�r��
			Console.WriteLine("�п�J�ɶ�:�~/��/�� ��:��:��");
			string _input = input;
			var obj = new TaiwanStockUtilities();



			//�P�_�榡
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

			//�P�_�O�_�b�Ѳ�����ɶ�
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
		public void Test2_�P����ɶ���(string input, bool istrue)
		{
			//���o�ϥΪ̿�J�r��
			Console.WriteLine("�п�J�ɶ�:�~/��/�� ��:��:��");
			string _input = input;
			var obj = new TaiwanStockUtilities();



			//�P�_�榡
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

			//�P�_�O�_�b�Ѳ�����ɶ�
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
		public void Test3_�P�����ɶ���(string input, bool istrue)
		{
			//���o�ϥΪ̿�J�r��
			Console.WriteLine("�п�J�ɶ�:�~/��/�� ��:��:��");
			string _input = input;
			var obj = new TaiwanStockUtilities();



			//�P�_�榡
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

			//�P�_�O�_�b�Ѳ�����ɶ�
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
		public void Test4_�P�����ɶ���(string input, bool istrue)
		{
			//���o�ϥΪ̿�J�r��
			Console.WriteLine("�п�J�ɶ�:�~/��/�� ��:��:��");
			string _input = input;
			var obj = new TaiwanStockUtilities();



			//�P�_�榡
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

			//�P�_�O�_�b�Ѳ�����ɶ�
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