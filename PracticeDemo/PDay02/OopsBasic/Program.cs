using System.Xml.Serialization;

namespace OopsBasic
{
    internal class Program
    {
       


        
        static void Main(string[] args)
        {


            Employee[] employees =  //upcasting
        {
            new PermantEmployee(1, "Priya", 60000, 3),
            new ContractEmployee(2, "Prachi", 50000, 12)
        };


            Console.WriteLine("Bonus ");
            foreach (var e in employees)
            {
                Console.WriteLine(e.calculateBonus());
            }

            Employee e1 = new PermantEmployee(3, "jyoti", 60000, 2);
            Console.WriteLine(e1);
        }
    }
}
