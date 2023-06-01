using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    internal class DbMoq
    {
        public static List<Product> Products { get; set; }
        

        static DbMoq()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Name = "Phone",
                    Cost = 23000,
                    Description = "Perfect phone",
                    Quantity = 20
                },
                new Product()
                {
                    Name = "TV",
                    Cost = 43000,
                    Description = "Perfect TV",
                    Quantity = 3
                },
                new Product()
                {
                    Name = "Laptop",
                    Cost = 55000,
                    Description = "Perfect laptop",
                    Quantity = 10
                },
                new Product()
                {
                    Name = "PC",
                    Cost = 123000,
                    Description = "Perfect PC",
                    Quantity = 6
                },
                new Product()
                {
                    Name = "Vacuum cleaner",
                    Cost = 5000,
                    Description = "Perfect vacuum cleaner",
                    Quantity = 10
                },
                new Product()
                {
                    Name = "Mouse",
                    Cost = 100,
                    Description = "Perfect mouse",
                    Quantity = 40
                },
                new Product()
                {
                    Name = "Washing machine",
                    Cost = 15000,
                    Description = "Perfect washing machine",
                    Quantity = 15
                },
                new Product()
                {
                    Name = "Keyboard",
                    Cost = 300,
                    Description = "Perfect keyboard",
                    Quantity = 50
                },
                new Product()
                {
                    Name = "Mixer",
                    Cost = 500,
                    Description = "Perfect mixer",
                    Quantity = 32
                },
                new Product()
                {
                    Name = "Tablet",
                    Cost = 44000,
                    Description = "Perfect tablet",
                    Quantity = 12
                }
            };
        }
    }
}
