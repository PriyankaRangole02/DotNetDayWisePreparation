using OopsBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsBasic2
{
    public class Salesman : Employee
    {
        public int Sales { get; set; }
        public double Commission { get; set; }

        public Salesman(int empid, String name, double salary, int sales, double commission):base(empid, name, salary)
        {
            
            this.Sales = sales;
            this.Commission = commission;
        }
        public override double calculateTotalSalary()
        {
            return salary+Sales * Commission;
        }

        public override string ToString()
        {
            return base.ToString()+$"sales:- {this.Sales}, Commission:- {this.Commission}";
        }

    }
}
