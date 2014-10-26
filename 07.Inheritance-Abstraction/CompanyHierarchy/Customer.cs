using System;

namespace CompanyHierarchy
{
    class Customer : Person
    {
        public double purchaseAmount;

        public Customer(double purchaseAmount)
        {
            this.purchaseAmount = purchaseAmount;
        }
    }
}
