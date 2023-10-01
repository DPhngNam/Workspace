namespace finalizer {
    class Abc {
        private string name;

        public Abc(string name) {
            this.name = name;
            Console.WriteLine("Any: " + name);
            Console.WriteLine(4);
        }

        public static void InFo(){
             Console.WriteLine(4);
        }
    }

    class inDex{
        public string fname ;
        public string lname;


        public string this[int index]{
            get {
            if (index == 0) return fname;
            else if (index == 1) return lname;
            else throw new Exception("Chỉ số không tồn tại");
         }

         // Gán dữ liệu theo chỉ mục
        set {
            if (index == 0)  fname = value;
            else if (index == 1) lname = value;
            else throw new Exception("Chỉ số không tồn tại");
        }
        }
    }

    class Program {
        static void Main(string[] args) {
            inDex obj = new inDex();

            obj.fname = "Doan";
            obj.fname = "Nam";

            Console.WriteLine(obj[1] + " " + obj[2]);

            
            
        }
    }
}
