
//C# most popular lang,free,cross platform,ron n everywhere,used to write phone ,computers ,servers,also most of the
//dotnet rumtiome and libraries written in c#
//C# is C family language C# syntax is familar to c,c++,java
//end of statement;
//Strongly typed language,type known as compile time
using System;
using System.Threading;

namespace HelloCSharp
{

    //entery point of program
    internal class Program
    {
        #region 
        //main can have any access  specifier except file
        /* static void Main() { }  //must be static
         static int Main() { }
        return type
         static void Main(string[] args) { }
         static int Main(string[] args) { }
        if may return Task,Task<int> only if they can have async modifier
        An advantage of declaring Main as async is that the compiler always generates the correct code.
         static async Task Main() { }
         static async Task<int> Main() { }         can be written without string[]
         static async Task Main(string[] args) { }
         static async Task<int> Main(string[] args) { }*/

        //static Task Main() results in the compiler emitting the equivalent of
        //private static void $GeneratedMain() => Main().GetAwaiter().GetResult();
        #endregion
        static void Main(string[] args)
        {
            //WriteLine method comes from Console class which in System namespace
            //System namespace was implicitly included it take input as a string
            Console.WriteLine();
            //to read the input
            Console.ReadLine();
            Console.Beep();

            Console.WriteLine("hiii");
            int i = 10;
            Console.WriteLine(i);
            //Console.Clear();




            #region  Console class
            Console.Title = "Understanding Console Class";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
           
            Console.Write("hii");
            string Name = "priyanka";
            Console.Write(Name);
            Console.WriteLine("this is myName" + Name);//with new line termination
            Console.WriteLine($"hello{Name}");



            Console.WriteLine("enter the key");
            int var=Console.Read();
             Console.WriteLine("using read()"+var);


            Console.WriteLine("enter the key ");
           ConsoleKeyInfo var2= Console.ReadKey();
            Console.Write($"the entered Key {var2.Key} and key:{var2.KeyChar} and Ascci:{(int)var2.KeyChar} ");
            #endregion

            #region How to read input from console (conversion)
            //and how to convert input into numeric as it by default take as string
            Console.WriteLine("enter the num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num1");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int add = num1 + num2;
            Console.WriteLine("Addition is " + add);
            double dnum1 = Convert.ToDouble(Console.ReadLine());
           

            #endregion


        }
    }

}


