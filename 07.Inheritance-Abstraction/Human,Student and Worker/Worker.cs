using System;

namespace Human_Student_and_Worker
{
    class Worker : Human
    {
        public int salary;
        public int workHoursPerDay;
        public int moneyPerHour;
        public Worker(int salary, int workHoursPerDay)
        {
            this.salary = salary;
            this.workHoursPerDay = workHoursPerDay;
        }
        public int MoneyPerHour()
        {
            int salary = this.salary;
            int workHoursPerDat = this.workHoursPerDay;
            salary = salary / 5;
            this.moneyPerHour = salary / workHoursPerDay;
            return this.moneyPerHour;
        }
    }
}
