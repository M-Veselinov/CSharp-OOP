using System;


namespace CompanyHierarchy
{
    class Sale 
    {
        public string ProductName;
        public string Date;
        public double Price;

        public Sale(string name,double price,string date)
        {
            this.ProductName = name;
            this.Price = price;
            this.Date = date;
        }
    }
}
