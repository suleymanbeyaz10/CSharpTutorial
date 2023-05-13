using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // case sensitive
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 400;
            product1.UnitsInStock = 10;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 4, UnitsInStock = 15 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            

        }
    }
}