namespace Day1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region compilation
            // program.cs=>compile=>MSIL code =>jit compiler=>dll or exe
            #endregion

            #region How to use command Line Argument
            //The args array can't be null.
            //So, it's safe to access the Length property without null checking.
            Console.WriteLine("enter the command Line argument ");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            //open devloper command prompt 
            // \Day1.2>dotnet build
            // \Day1.2=>dotnet run -- 10 20

            #endregion

            #region  Simple array
            int[] arr = new int[]{ 10, 20, 30, 40 };//declaring and assigning values to the array at the same time

            //another way
            //Declaring Array
            int[] arr1 = new int[3];
            //and then Initializing
            arr1[0] = 10;
            arr1[1] = 20;

            //to read values using traditional loop

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            //to print values using forEach loop  uncomment ctrl+k+u
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
            #endregion

        }
    }
}


