// See https://aka.ms/new-console-template for more information

using Task5._2;

Console.WriteLine("Hello, World!");

using (MyDatabaseContext database = new MyDatabaseContext())
{
    database.Products.Add(new Product()
    {
        Name = "Phone",
        Cost = 23000,
        Description = "Perfect phone",
        Quantity = 20
    });
    database.Products.Add(new Product()
    {
        Name = "TV",
        Cost = 43000,
        Description = "Perfect TV",
        Quantity = 3
    });
    database.Products.Add(new Product()
    {
        Name = "Laptop",
        Cost = 55000,
        Description = "Perfect laptop",
        Quantity = 10
    });
    database.Products.Add(new Product()
    {
        Name = "PC",
        Cost = 123000,
        Description = "Perfect PC",
        Quantity = 6
    });
    database.Products.Add(new Product()
    {
        Name = "Vacuum cleaner",
        Cost = 5000,
        Description = "Perfect vacuum cleaner",
        Quantity = 10
    });
    database.Products.Add(new Product()
    {
        Name = "Mouse",
        Cost = 100,
        Description = "Perfect mouse",
        Quantity = 40
    });
    database.Products.Add(new Product()
    {
        Name = "Washing machine",
        Cost = 15000,
        Description = "Perfect washing machine",
        Quantity = 15
    });
    database.Products.Add(new Product()
    {
        Name = "Keyboard",
        Cost = 300,
        Description = "Perfect keyboard",
        Quantity = 50
    });
    database.Products.Add(new Product()
    {
        Name = "Mixer",
        Cost = 500,
        Description = "Perfect mixer",
        Quantity = 32
    });
    database.Products.Add(new Product()
    {
        Name = "Tablet",
        Cost = 44000,
        Description = "Perfect tablet",
        Quantity = 12
    });
    database.SaveChanges();
}

using (MyDatabaseContext database = new MyDatabaseContext())
{
    var products = database.Products.ToList();
    for (int i = 0; i < products.Count; i++)
    {
        
        if (i == 1 || i == 0 || i == 5 || i == 7)
        {
            Console.WriteLine($"Name: {products[i].Name}\n" +
                              $"Cost: {products[i].Cost}\n" +
                              $"Description: {products[i].Description}\n" +
                              $"Quantity: {products[i].Quantity}\n");
        }
    }
}