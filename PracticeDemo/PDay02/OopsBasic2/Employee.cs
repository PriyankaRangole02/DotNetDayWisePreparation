using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasic
{
    public abstract class Employee
    {

        
        private int id;
        private string name;
        protected double salary;

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public Employee()
        {

        }
        public int Id
        {
            get { return id; }

        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { if (salary < 0) salary = 0;
                else { salary = value; } }
        }

        public override string ToString()
        {
            return $"{this.id} {this.name} {this.salary}";
        }

        public abstract double calculateTotalSalary();
        

    }
}
