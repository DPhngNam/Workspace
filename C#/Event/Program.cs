namespace Event
{
	public delegate void Sukien(int x);

	// Publisher
	class Dulieunhp : EventArgs
	{
		public int data {get;set;}

		public Dulieunhp(int x)=> data =x;
	}
	
	
	class userInput
	{
		public event EventHandler Sk; 
		// ~Delegate void KIEU(object? sender, EventArgs args)

		public void Input()
		{
			string s = Console.ReadLine();
			int i = Int32.Parse(s);

			Sk?.Invoke(this, new Dulieunhp(i));
		}
	}
	
	class tinhCan
	{
		
		public void Sub(userInput inp)
		{
			inp.Sk += Can; // Subscribe to the event using +=
		}
		
		public void Can(object? sender,EventArgs e)
		{
			Dulieunhp dulieunhap = (Dulieunhp) e;
			int i = dulieunhap.data;
			Console.WriteLine($"Can bac hai cua {i} la {Math.Sqrt(i)}");
		}
	}

	class binhPhuong
	{
		public void Sub(userInput inp)
		{
			inp.Sk += Bp; // Subscribe to the event using +=
		}

		public void Bp(object? sender,EventArgs e)
		{
			Dulieunhp dulieunhap = (Dulieunhp) e;
			int i = dulieunhap.data;
			Console.WriteLine($"Binh phuong cua {i} la {i*i}");
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			
			userInput uIn = new userInput();
 
			uIn.Sk += (sneder,e)=>{
				Dulieunhp dulieunhap = (Dulieunhp) e;
				Console.WriteLine("Ban vua nhap so "+ dulieunhap.data);
			};

			tinhCan tc = new tinhCan();
			binhPhuong bp = new binhPhuong();

			// Correct method call
			tc.Sub(uIn);
			bp.Sub(uIn);

			uIn.Input();


			

		}
	}
}
