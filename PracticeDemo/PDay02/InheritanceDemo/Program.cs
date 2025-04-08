namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account savingAccount = new SavingAccount();

            //AccountNo:1001 AccountHolder:priya    Balance:3000
            savingAccount.Acceptdetails();
            savingAccount.PerformOperations();
            Console.WriteLine(savingAccount);


            Account pfAccount = new PFAccount();

            // //AccountNo:1001 AccountHolder:priya    Balance:3000
            pfAccount.Acceptdetails();  
            Console.WriteLine(pfAccount);

            //Amount to contribute:1000 =>New bal 3000+1000=4000<5000 (contribution limit)
            pfAccount.PerformOperations();
            Console.WriteLine(pfAccount);
            //contribution amount=2000   4000+2000=6000<5000 limit exceeded
            pfAccount.PerformOperations();


        }
    }
}
