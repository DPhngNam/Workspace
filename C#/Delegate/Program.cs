namespace Delegate
{
	//Khai báo một delegate
	public delegate void showLog(string mess);
	
	class Programm
	{
		//Phương thức tương đồng với Showlog(tham số, kiểu trả về)
		static public void Info(string s)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(string.Format("Info: {0}",s));
			Console.ResetColor();
		}
		
		static public void Warn(string s)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(string.Format("Warning: {0}",s));
			Console.ResetColor();
		}
		
		
		//Func and Action ko cần khai báo
		
		
		
		//Action
		public static int Tong(int x, int y) => x+y;
		// {
		// 	return x+y;
		// }
		
		
		static void Main(string[] args)
		{
			
			// showLog log = null;
			// log = (x) => Console.WriteLine(string.Format("==>{0}<==",x));
			
			// var all = log;
			// all("xin chao");
			
			// Action ac;
			// Action<string, int, bool> act; // ~ delegate void KIEU(string s, int t, bool flag)
			// Action<string> acti;
			// acti = Warn;
			// acti("Thong bao loa loa loa");
			
			
			/*
			Func<int> fc; ~ delegate int KIEU(int t)
			Func<string,double> f2; ~ delegate double KIEU(string,double), kiểu trả về dựa vào tham số cuối cùng
			*/
			
			Func<int,int,int> tt;
			int a = 100; int b = 2;
			tt = Tong;
			Console.WriteLine($"tong la {tt(a,b)}");
			
		}
	}
}