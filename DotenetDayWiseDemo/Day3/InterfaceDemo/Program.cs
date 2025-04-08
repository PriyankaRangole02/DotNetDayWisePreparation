namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public interface IX
    {
        public int Add(int x, int y);
        public int Sub(int x, int y);
    }
    public interface IY
    {
        public int Mul(int x, int y);
        public int Div(int x, int y);
    }

    public class Maths : IX, IY
    {
        public int Div(int x, int y)
        {
            return x + y; ;
        }

        public int Mul(int x, int y)
        {
            return x*y;
        }

        public int Add(int x, int y)
        {
            return x + y; ;
        }

        public int Sub(int x, int y)
        {
            return x-y;
        }

       

       
    }
}
