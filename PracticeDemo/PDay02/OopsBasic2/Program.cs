using OopsBasic;

namespace OopsBasic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee(1, "Anil", 10000);  //error cannot instantiates cause abstract class

            Employee[] earr = {

              new Manager(1, "Anil", 10000, 2000),
              new Manager(1, "Anil", 10000, 2000),
              new Salesman(1, "Anil", 1000, 100, 0.20),
              new Salesman(1, "Anil", 10000, 200, 0.10)
        };

            foreach (Employee e in earr)
                Console.WriteLine("Total salary "+e.calculateTotalSalary());





        }
    }
}
