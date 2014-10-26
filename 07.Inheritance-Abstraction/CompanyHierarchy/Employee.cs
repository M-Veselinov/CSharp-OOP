using System;
using System.Linq;

namespace CompanyHierarchy
{
    class Employee : Person,IEmployee
    {
        public double salary;
        public string department;

        public Employee()
        {

        }
        public Employee(double salary,string department)
        {
            string[] arr = {"Production","Accounting","Sales","Marketing" };
            if (arr.Contains(department))
            {
                this.department = department;
            }
            this.salary = salary;
        }
    }
}
