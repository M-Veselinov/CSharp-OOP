using System;

namespace Human_Student_and_Worker
{
    class Student : Human
    {
        public string facultyNumber;

        public Student(string facultyNumber)
        {
            this.facultyNumber = facultyNumber;
        }
    }
}
