namespace lambda{
    public delegate int tnhTong(int a, int b);
    class lambDa{
        public static void Main(string[] args){
            int x = Convert.ToInt32(Console.ReadLine());
            int v = Convert.ToInt32(Console.ReadLine());

            tnhTong tt=(int x, int v) => {return x+v;};

            Console.WriteLine(tt(x,v));
            
        }
    }
}