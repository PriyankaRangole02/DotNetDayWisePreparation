namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region simple File Write
            string path = "D:\\Sunbeam\\Dronacharya\\DotNetDayWisePreparation\\Day5\\filedemo.txt";
            FileStream fileStream = null;
            if(File.Exists(path))
            {
                fileStream = new FileStream(path, FileMode.Append,FileAccess.Write);

            }
           else {
                fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            }
            StreamWriter writer = new StreamWriter(fileStream);
            Console.WriteLine("enter the something to write ");
            string data = Console.ReadLine();
            writer.WriteLine(data);
            writer.Close();
            fileStream.Close();
            #endregion

            #region File Read

            if(File.Exists(path))
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                 data = streamReader.ReadToEnd();
                Console.WriteLine(data);
                streamReader.Close();
                fileStream.Close();
            }
            #endregion

        }
    }
   
}
