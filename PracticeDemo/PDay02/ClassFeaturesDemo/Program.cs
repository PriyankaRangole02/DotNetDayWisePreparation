namespace ClassFeaturesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Console.WriteLine(product);
            //  product.ToString();
            Console.WriteLine("enter the productDetails");
            Console.WriteLine("enetr the ProductId ");
            product.Pid = Convert.ToInt32(Console.ReadLine());
            product.Name = "mobile";
            Console.WriteLine(product.Name);

            Console.WriteLine("enter the pname");
            product.Name = Console.ReadLine();

            Console.WriteLine("enter the Expire date");
            product.ExpDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine(product);
            Product product1 = new Product("garam masala", new DateOnly(2025,04,08));

            Product product2 = new Product  //it invoked paramterless ctor
            {
                Name = "garam masala",
                ExpDate = new DateOnly(2025, 04, 08)
            };
            Console.WriteLine(product2);



        }
    }

   /* public class Product
    {

    }
    public class Student
    {

    }*/
}
