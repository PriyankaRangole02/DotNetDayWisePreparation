using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFeaturesDemo
{
    internal class Product
    {
        //auto propety false;
        private int pid;

        //what if i want to auto increament productId;
        private static int pidCounter=1001;

        


       // private string pname;
        private DateOnly expDate; //or use string

        public Product()
        {
             this.pid = 0;
           

            //this.pidCounter = 0;   //error
            // this.pname = null;
            this.Name = null;
            this.expDate = new DateOnly(2025,12,1);

        }

        public Product(int pid, string pname, DateOnly expDate)
        {
            this.pid = pid;
            //this.pname = pname;
            this.Name = "";
            this.expDate = expDate;
        }

        //if pid is auto-incremeted so we dont in ctor

        public Product(string name,DateOnly expDate)
        {
            this.pid = ++pidCounter;
            this.Name = name;
            this.expDate = expDate;
        }

        // dotnet_style_prefer_auto_properties = true
        public string Name { get; set; }

        //back field proprty
        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
       

        public DateOnly ExpDate
        {
            get { return expDate; }
            set { expDate = value; }
        }

        public override string ToString()
        {
            return $"ProductId:- {pid}  productName:-{Name} ExpDate:-{expDate}";
        }



    }
}
