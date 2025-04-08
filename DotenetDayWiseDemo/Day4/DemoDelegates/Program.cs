namespace DemoDelegates
{
    //same signature follow by method which passeed as parameter
    delegate bool MyDelegates(int i);
    internal class Program
    {
        static void Main(string[] args)
        {
            //delegates as function pinter
            MyDelegates d = new MyDelegates(Check);
            bool result = d(200);
            Console.WriteLine(result);
        }
        public static  bool Check(int i)
        {
            return i > 10;
        }
    }
}
