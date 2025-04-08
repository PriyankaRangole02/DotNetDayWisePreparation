namespace InheritanceDemoOnGeneric
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
           
            int p = 100;
            int q = 200;



            SpecialMaths<int, short, string, bool> maths  =new SpecialMaths<int, short, string, bool>();

            bool result = maths.GenericDemoMethod(10, 2, "abd", true);
            Console.WriteLine("Result of Nonsense method is " + result);

            Console.WriteLine("Before Swap p = {0}, q = {1}", p, q);
            maths.Swap(ref p, ref q);

            Console.WriteLine("After Swap p = {0}, q = {1}", p, q);

            

            Console.WriteLine("Before Swap p = {0}, q = {1}", p, q);

            SpecialMaths maths1 = new SpecialMaths();
            maths1.Swap(ref p, ref q);

            Console.WriteLine("After Swap p = {0}, q = {1}", p, q);



        }
    }


        #region inheritance generic class into non Generic class

        public class Maths<T>
        {

            public int Add(int x, int y)
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



    public class SpecialMaths : Maths<int>
    {

        /*public S GenericDemoMethod(P para1, Q para2, R para3, S para4)
        {
            return para4;
        }*/

    }
    #endregion

    #region Inherits Generic class in Generic class
    public class SpecialMaths<P,Q,R,S> : Maths<P>
    {
       
        public S GenericDemoMethod(P para1, Q para2, R para3, S para4)
        {
            return para4;
        }

    }
    #endregion


}



