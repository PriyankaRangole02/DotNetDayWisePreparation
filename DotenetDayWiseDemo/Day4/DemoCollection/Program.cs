namespace DemoCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing unBoxing
            int i = 100; //stack
            object obj = i;//Heap  //Boxing
            int j = Convert.ToInt32(obj);//unboxing


            #endregion

            #region int array
            int[] arr = new int[] { 10, 20, 30 };
            int[] arr2 = new int[3];
            arr2[0] = 10;
            arr2[1] = 20;


            for (int k= 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }

            foreach(int v in arr2)
                Console.WriteLine(v);



            #endregion

            #region Emp object Declared/Defined
            Emp e1 = new Emp();
            e1.empid = 10;
            e1.name = "priya";


            Emp e2 = new Emp();
            e2.empid = 11;
            e2.name = "Jyoti";

            #endregion

            #region Simple casting
             Object obj1 = e1;
            // Emp e3 = (Emp)obj1;

            Emp e3 = obj1 as Emp;


            #endregion

            #region Simple Emp Array
            Emp[] earr = new Emp[] { e1,e2 };

            foreach (Emp emp in earr)
                Console.WriteLine(emp.name);
            #endregion

            #region Object array
            Emp e = new Emp();
            Object[] oarr = new object[4];
            oarr[0] = 103;
            oarr[1] = "hiii";
            oarr[2] = e1;

            foreach(object ob in oarr)
            {
                if(ob is Emp)
                {
                    Emp emp = (Emp)ob;
                    Console.WriteLine("Welcome " + emp.name);
                }
                else if(ob is int)
                {
                    //int k = Convert.ToInt32(ob);
                    int k = (int)ob;
                    Console.WriteLine(k);
                }
                else if(ob is string)
                {
                    //string s = ob.ToString();
                    // string s = Convert.ToString(ob);
                    string s = (string)ob;
                    Console.WriteLine(s);


                }
                else
                {
                    Console.WriteLine("unknown data type");
                }
            }


            #endregion



        }
    }

    class Emp
    {
         public int empid { get; set; }

       public  string name { get; set; }

        public Emp()
        {
            
        }
        public Emp( int empid,string name)
        {
            this.empid = empid;
            this.name = name;
        }

    }
}
