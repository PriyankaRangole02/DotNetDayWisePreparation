using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class SavingAccount : Account
    {
        public static  double InterestRate=0.10;
       

        public override void Acceptdetails()
        {
            base.Acceptdetails();
            Console.WriteLine("enter the balance");
            this.balance= Double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString()+$"Balance: {balance} InterestRate:{InterestRate}";
        }

        //saving account perform action on interest rate
        public override void PerformOperations()
        {
            balance+=balance*InterestRate;
            Console.WriteLine($"your saving Account balance is {balance}");
        }
    }
}
