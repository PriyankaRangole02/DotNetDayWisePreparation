using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class PFAccount : Account
    {
        public static double ContributionLimit=5000;//every pf instance has fixed contribution limit

        public override void Acceptdetails()
        {
            base.Acceptdetails();

        }


        //contribution depends on contribution limit
        public override void PerformOperations()
        {
            Console.WriteLine("enter the amount to contribute");
            float amount = Convert.ToInt32(Console.ReadLine());
            if (balance + amount <= ContributionLimit) 
            {
                balance += amount;
                Console.WriteLine("contributed successfully");
            }
            else
                Console.WriteLine($"Contribution falied..excced limit of {ContributionLimit}");

           
        }

        public override string ToString()
        {
            return base.ToString() + $"Balance: {balance} ContributionLimit:{ContributionLimit}";
        }
    }
}
