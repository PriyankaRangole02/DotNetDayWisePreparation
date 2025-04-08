namespace DemoNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int p = 100;
            int q = 200;*/
            string p= "priya";
            string q = "jyoti";

            string format = "Before Swap p={0} ,q={1}";
            string message = string.Format(format, p, q);
            Console.WriteLine(message);
            Maths maths = new Maths();
            maths.swap( ref p, ref q);
            Console.WriteLine("After Swap p = {0}, q = {1}", p, q);
        }
    }

    public class Maths
    {
        public void swap( ref int x,  ref int y)
        {
            int z = x;
             x = y;
            y = z;
        }
        public void swap(ref string x, ref string y)
        {
            string z = x;
            x = y;
            y = z;
        }
    }
}
