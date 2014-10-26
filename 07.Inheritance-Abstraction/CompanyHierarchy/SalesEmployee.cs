using System;

namespace CompanyHierarchy
{
    class SalesEmployee : Employee
    {
        public Sale[] arr;

        public SalesEmployee() { }
        public SalesEmployee(Sale[] array)
        {
            this.arr = new Sale[array.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = array[i];
            }
        }
    }
}
