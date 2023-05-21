using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ahmet Duman
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Ahmet";
            customer1.Surname = "Duman";
            customer1.IdNumber = "123456578910";


            //Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";


            Customer customer3  = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
        
        }
    }
}