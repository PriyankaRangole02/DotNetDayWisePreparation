using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    /// <summary>
    /// if you write abstract method in class then class must be abstract
    /// </summary>
    public abstract class Account
    {
        private int  AccountNo;
        private string AccountHolder;
        protected double balance;
        





        public Account()
        {
            
        }

        public Account(string name)
        {
            Name = name;
           
        }

        public Account(int accountNo, string name)
        {
            AccountNo = accountNo;
            Name = name;
           
        }

        public int AccoNo
        {
            set {  AccountNo=value; }
            get { return AccountNo; }
        }
        public string Name
        {
            set { AccountHolder = value; }
            get { return AccountHolder; }
        }

        //every Accountype has different operation to perform 
         public abstract void PerformOperations();
        // public abstract double CalculateInterest();

        public virtual void Acceptdetails()
        {

            //common details of every account
            Console.WriteLine("enter the AccountNo: ");
            this.AccountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the AccountNo: ");
            this.AccountHolder = Console.ReadLine();


        }

        public override string ToString()
        {
            return $"{AccountNo}  Account Holder Name;: {Name}";
        }
       




    }
}
