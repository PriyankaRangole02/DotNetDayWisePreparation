using System.ComponentModel;
using System.ComponentModel.Design;
using System.Xml.Serialization;
using MathsLib;

namespace Assignment1
{
    internal class Program
    {
        #region Assignment1 using commandLine and Args
        static void Main(string[] args)
        {

            #region  by CommandLine Args
            //int num1 = Convert.ToInt32(args[0]);

            //char operation = Convert.ToChar(args[1]);

            //// int.Parse(args[0]);
            //int num2 = Convert.ToInt32(args[2]);
            #endregion



            char operation;
            do
            {
                #region Menu Driven

                Console.WriteLine("\n1. + \n2. -  \n3. * \n4. /  \n0.exit");
                   Console.WriteLine("enter the operation ");
                operation = Convert.ToChar(Console.ReadLine());
                #endregion



                // int.Parse(args[0]);


                switch (operation)   //Q1
                {
                    case '+':
                        Console.WriteLine("Enter the first and Second Number");
                        Console.WriteLine(Add(Convert.ToInt32(Console.ReadLine())
                        ,Convert.ToInt32(Console.ReadLine())));


                        
                        break;
                    case '-':
                        Console.WriteLine("Enter the first and Second Number");
                        Console.WriteLine(Sub(Convert.ToInt32(Console.ReadLine())
                        , Convert.ToInt32(Console.ReadLine())));
                        break;
                    case '*':
                        Console.WriteLine("Enter the first and Second Number");
                        Console.WriteLine(Mul(Convert.ToInt32(Console.ReadLine())
                        , Convert.ToInt32(Console.ReadLine())));
                        break;
                    case '/':
                        Console.WriteLine("Enter the first and Second Number");
                        Console.WriteLine(Div(Convert.ToInt32(Console.ReadLine())
                        , Convert.ToInt32(Console.ReadLine())));
                        break;
                    case '0':
                        Console.WriteLine("Thnak you....");
                        break;
                }
            } while (operation!= '0');
        }
        



        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public static string Div(int num1, int num2)
        {
            if (num2 != 0)
                return $"result is {num1 / num2}";
            else 
                return "cannot divided by zero";

        }


    }
}
    #endregion

    #region Assignment using class Library
    //static void Main(string[] args) {
    //    Console.WriteLine("enter the Number1 ");
    //    int num1 = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("enter the operation ");
    //    char operation = Convert.ToChar(Console.ReadLine());

    //    Console.WriteLine("enter the Number2 ");
    //    int num2 = Convert.ToInt32(Console.ReadLine());

    //    Maths m = new Maths();
    //   Console.WriteLine( m.Add(num1, num2));

    #endregion


