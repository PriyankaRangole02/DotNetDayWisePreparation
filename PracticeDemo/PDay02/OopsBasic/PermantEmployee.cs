using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasic
{
    public class PermantEmployee : Employee
    {
        public double yearOfService { get; }
        public override double calculateBonus()
        {
            return salary * 0.10 * yearOfService;
        }

        public PermantEmployee(int id, string name, double salary, double yearOfService) : base(id, name, salary)
        {
            this.yearOfService = yearOfService;
        }

        public override string ToString()
        {
            return base.ToString()+$"{yearOfService}";
        }
    }
}
