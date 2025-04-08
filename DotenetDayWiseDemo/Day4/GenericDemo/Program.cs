namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int p = 100;
            int q = 200;*/
            string p = "priya";
            string q = "jyoti";
            Console.WriteLine("Before Swapping p={0} ,q={1}",p,q);
            /* Maths<int> maths = new Maths<int>();*/

            Maths<string> maths = new Maths<string>();
            Maths maths1 = new Maths();

            maths.Swap(ref p, ref q);
            maths.Add(10, 20);
            maths1.Add(10, 20);
            maths1.Swap( ref p, ref q);
            Console.WriteLine("After Swapping p={0} ,q={1}",p,q);

            Maths m1 = new Maths();

        }
    }


    #region Generic class with generic method and non-generic method;

    public class Maths<T>
    {

        public int Add(int x,int y)
        {
            return x = y;
        }
        public void Swap(ref T x, ref T y)
        {
            T z = x;
            x = y;

            y = z;
        }
    }
    #endregion

    #region Non-generic class with Generic method and non generic method
    public class Maths
    {
        public int Add(int x, int y)
        {
            return x = y;
        }
        public void Swap<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;

            y = z;
        }

    }
    #endregion

}
