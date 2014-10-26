using System;

namespace CompanyHierarchy
{
    class Manager : Employee,IManager
    {
        public Employee[] employees;
        public Manager() { }
        public Manager(Employee[] employee)
        {
            this.employees = new Employee[employee.Length];
            for (int i = 0; i < employee.Length; i++)
            {
                this.employees[i] = employee[i];
            }
        }
    }
}
