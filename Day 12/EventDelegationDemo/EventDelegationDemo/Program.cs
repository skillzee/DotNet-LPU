using EventDelegationDemo;

namespace EventDelegationDemo
{
    public delegate bool CreateRecord(Product p);
    public delegate void Caller(string str);

    class Program
    {   

        public static void ShowMe(string str)
        {
            Console.WriteLine("Show Me Called"); 
        }

        public void GenerateBill(string str)    
        {
            Console.WriteLine("Generate Bill Called");
        }


        static void Main()
        {
            Program p1 = new Program();
            Caller CallMe = new Caller(Program.ShowMe);
            CallMe+= new Caller(p1.GenerateBill);

            CallMe("LPU");



        }
    }
}
