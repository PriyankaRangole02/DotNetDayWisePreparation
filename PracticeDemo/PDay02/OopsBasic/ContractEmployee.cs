using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasic
{
    public class ContractEmployee:Employee
    {
        public double ContractMonths { get; }

        public ContractEmployee(int id,string name,double salary,double contractMonths):base(id,name,salary)
        {

            ContractMonths = contractMonths;
        }

        public override double calculateBonus()
        {
            return salary * 0.05 * ContractMonths;
        }

        public override string ToString()
        {
            return base.ToString()+$"{this.ContractMonths}";
        }
    }
}
