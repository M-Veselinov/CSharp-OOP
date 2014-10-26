using System;

namespace CompanyHierarchy
{
    class Developer : RegularEmployee
    {
        public Project[] arr;
        public Developer() { }
        
        public Developer(Project[] arr)
        {
            this.arr = new Project[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }
    }
}
