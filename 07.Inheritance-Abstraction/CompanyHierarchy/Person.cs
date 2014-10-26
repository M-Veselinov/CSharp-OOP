using System;

namespace CompanyHierarchy
{
    class Person : IPerson
    {
        public string id;
        public string firstName;
        public string lastName;

        public Person() { }

        public Person(string id,string fName,string lName)
        {
            this.id = id;
            this.firstName = fName;
            this.lastName = lName;
        }
    }
}
