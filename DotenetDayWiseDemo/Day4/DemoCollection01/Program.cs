using System.Collections;

namespace DemoCollection01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(new Emp(10, "priya", "kop"));
            arr.Add(new Emp(10, "jyoti", "karad"));
            arr.Add(new Emp(10, "prachi", "pune"));
            arr.Add(101);
            arr.Add("hii");
            arr.Add(true);

            foreach(object obj in arr)
            {
                if(obj is Emp)
                {
                    Emp e = (Emp)obj;
                    Console.WriteLine("Welcome  " + e.Name);
                }
                else if (obj is int)
                {
                    //int i = Convert.ToInt32(i);
                    int i = (int)obj;
                    Console.WriteLine(i);
                }
                else if (obj is string)
                {
                    //string s = obj.ToString();
                    //string s = Convert.ToString(obj);
                    string s = (string)obj;
                    Console.WriteLine(s);
                }
                else if(obj is bool)
                {
                    bool s = (bool)obj;
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("Unknown type of data!");
                }
            }

            #region Find Something from arrayList
            ArrayList emparr = new ArrayList();
            while(true)
            {
                Emp emp = new Emp();
                Console.WriteLine("enter the no");
                emp.No = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Name");
                emp.Name = Console.ReadLine();

                Console.WriteLine("enter eaddress");
                emp.Address = Console.ReadLine();

                emparr.Add(emp);
                Console.WriteLine("Do you want to continue?");

                string choice = Console.ReadLine();
                if (choice == "no")
                {
                    break;
                }
            }

            foreach (object obj in emparr)
            {
                Emp emp = (Emp)obj;
                Console.WriteLine("Welcome " + emp.Name + " from " + emp.Address);
            }


            Console.WriteLine("Enter the number ");
            int no = Convert.ToInt32(Console.ReadLine());

            foreach (object obj in emparr)
            {
                Emp emp = (Emp)obj;
                if (emp.No == no)
                {
                    Console.WriteLine("Welcome " + emp.Name + " from " + emp.Address);
                    break;
                }
            }


        }
        #endregion





    }
    

    public class Book
    {
       
        private string  _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

    }
    
}
