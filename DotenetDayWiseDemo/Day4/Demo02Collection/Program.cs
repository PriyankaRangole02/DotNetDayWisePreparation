using DemoCollection01;
using System.Collections;

namespace Demo02Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Emp e1= new Emp(10, "priya", "kop"));
            Emp e2 =new Emp(9, "jyoti", "karad");
            Emp e3 =new Emp(8, "prachi", "pune");
            #region HashTable =>Non-Generic

            Hashtable hashtable = new Hashtable();
            hashtable.Add(e1.No, e1);
            hashtable.Add(e2.No, e2);
            hashtable.Add(e3.No, e3);
            hashtable.Add(99, "hiii");
            hashtable.Add(77, new Emp(4, "gita", "satara"));

            #endregion

            #region List<T>  Generic type
            List<Emp> arr = new List<Emp>();
            arr.Add(e1);
            arr.Add(e2);
            arr.Add(e3);
           // arr.Add(100);

            foreach (Emp emp in arr)
            {
                Console.WriteLine(" List Welcome " + emp.Name);
            }
            #endregion


            #region Stack<T>

            Stack<Emp> sarr = new Stack<Emp>();
            sarr.Push(e1);
            sarr.Push(e2);
            sarr.Push(e3);


            foreach (Emp emp in sarr)
            {
                Console.WriteLine(" Stack Welcome " + emp.Name);
            }

            #endregion

            #region Queue<T>
            Queue<Emp> earr = new Queue<Emp>();
            earr.Enqueue(e1);
            earr.Enqueue(e2);
            earr.Enqueue(e3);


            foreach (Emp emp in earr)
            {
                Console.WriteLine(" Queue Welcome " + emp.Name);
            }
            #endregion

            #region Dictionary<Key, Value>
            Dictionary<int, Emp> darr = new Dictionary<int, Emp>();
            darr.Add(e1.No, e1);
            darr.Add(e2.No, e2);
            darr.Add(e3.No, e3);

            Console.WriteLine("Enter No to FInd");
            int no = Convert.ToInt32(Console.ReadLine());

            Emp empFound = darr[no];

            Console.WriteLine("Welcome " + empFound.Name);
            #endregion
        }
    }
}
