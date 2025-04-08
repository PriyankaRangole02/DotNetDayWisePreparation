using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DemoFileIO_ObjectWrite
{
    internal class Program
    {
        static void Main(string[] args)
 {

            #region Object write
            string path = "D:\\Sunbeam\\Dronacharya\\DotNetDayWisePreparation\\Day5\\fileObjectdemo.txt";

            FileStream f = null;
            if(File.Exists(path))
                {
                f = new FileStream(path, FileMode.Append, FileAccess.Write);


            }
            else
            {
                f = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            }

            BinaryFormatter spwriter = new BinaryFormatter();//.net 6.0 SYSLIB0011

            Emp e = new Emp();
            Console.WriteLine("enter the Emp Name ");
            e.Name = Console.ReadLine();
            Console.WriteLine("enter the Emp No ");
            e.No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Emp Address ");
            e.Address = Console.ReadLine();

            spwriter.Serialize(f, e);
            spwriter = null;
            f.Close();

            #endregion
            Console.ReadLine();

            #region Object Read
            if(File.Exists(path))
            {
                f = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter reader = new BinaryFormatter();
                while (f.Position < f.Length)
                {
                    Emp e2 = (Emp)reader.Deserialize(f);

                    Console.WriteLine($"Empname= {e2.Name}");
                    Console.WriteLine($"EmpNo  {e2.No} ");
                    Console.WriteLine($"");
                }
            }

            f.Close();

            #endregion










        }
    }


    
}
