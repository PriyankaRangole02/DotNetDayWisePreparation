using OopsBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsBasic2
{
    public class Manager:Employee
    {
       public double bonus { set; get; }
        public Manager()
        {
        }

        public Manager(int empid, String name, double salary, double bonus) : base(empid, name, salary)
        {
           
            this.bonus = bonus;
        }

        public override double calculateTotalSalary()
        {
            return   salary + bonus;
        }

        public override string ToString()
        {
            return base.ToString() + $"Bonus:- {this.bonus}";
        }
    }
}
