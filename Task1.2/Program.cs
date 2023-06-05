// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Task1._2;
using Task1._2.Enum;
using Task5._2;



//using (MyDatabaseContext database = new MyDatabaseContext())
//{
//    database.Users.AddAsync(new User()
//    {
//        Name = "Dina",
//        Login = "dina",
//        Password = "123",
//        Email = "dina@gmail.com"
//    });
//    database.Users.AddAsync(new User()
//    {
//        Name = "Viktor",
//        Login = "viktor",
//        Password = "112233",
//        Email = "viktor@gmail.com"
//    });

//    database.SaveChangesAsync();
//}

//using (MyDatabaseContext database = new MyDatabaseContext())
//{
//    database.Products.AddAsync(new Product()
//    {
//        Name = "Phone",
//        Price = 23000,
//        ActionPrice = 20000,
//        Description = "Perfect phone",
//        DescriptionField1 = "Cool",
//        DescriptionField2 = "Top",
//        ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-13-pink-select-2021?wid=940&hei=1112&fmt=png-alpha&.v=1645572315935",
//        Category = new Category()
//        {
//            Name = "Electronic",
//            Icon = "Electronic"
//        },
//        Cart = new List<Cart>(new Cart[]
//        {
//            new Cart()
//            {
//                UsersUser = new User()
//                {
//                    Name = "Dina",
//                    Login = "dina",
//                    Password = "123",
//                    Email = "dina@gmail.com"
//                }
//            }
//        }),
//        KeyWords = new List<KeyParams>(new KeyParams[]
//        {
//            new KeyParams()
//            {
//                KeyWords = new Word()
//                {
//                    Header = "phone",
//                    KeyWord = "phone, telephone"
//                }
//            }
//        })

//    });
//    database.Products.AddAsync(new Product()
//    {
//        Name = "TV",
//        Price = 43000,
//        ActionPrice = 29000,
//        Description = "Perfect TV",
//        DescriptionField1 = "Super",
//        DescriptionField2 = "Top",
//        ImageUrl = "httpTVImageUrl",
//        Category = new Category()
//        {
//            Name = "Technick",
//            Icon = "https://w7.pngwing.com/pngs/41/184/png-transparent-flat-screen-tv-liquid-crystal-display-led-backlit-lcd-4k-resolution-smart-tv-television-4k-hard-screen-lcd-tv-support-wall-display-advertising-color-dual.png"
//        },
//        Cart = new List<Cart>(new Cart[]
//        {
//            new Cart()
//            {
//                UsersUser = new User()
//                {
//                    Name = "Viktor",
//                    Login = "viktor",
//                    Password = "112233",
//                    Email = "viktor@gmail.com"
//                }
//            }
//        })
//    });
//    database.SaveChanges();
//}
//        KeyWords = new List<KeyParams>(new KeyParams[]
//        {
//            new KeyParams()
//            {
//                KeyWords = new Word()
//                {
//                    Header = "TV",
//                    KeyWord = "TV, television"
//                }
//            }
//        })
//    });
//    database.Products.AddAsync(new Product()
//    {
//        Name = "Laptop",
//        Price = 55000,
//        ActionPrice = 35000,
//        Description = "Perfect Laptop",
//        DescriptionField1 = "Super Laptop",
//        DescriptionField2 = "Top Laptop",
//        ImageUrl = "httpLaptopImageUrl",
//        Category = new Category()
//        {
//            Name = "PC",
//            Icon = "PC"
//        },
//        Cart = new List<Cart>(new Cart[]
//        {
//            new Cart()
//            {
//                UsersUser = new User()
//                {
//                    Name = "Dina",
//                    Login = "dina",
//                    Password = "123",
//                    Email = "dina@gmail.com"
//                }
//            }
//        }),
//        KeyWords = new List<KeyParams>(new KeyParams[]
//        {
//            new KeyParams()
//            {
//                KeyWords = new Word()
//                {
//                    Header = "Laptop",
//                    KeyWord = "Laptop, notebook, pc"
//                }
//            }
//        })
//    });
//    database.Products.AddAsync(new Product()
//    {
//        Name = "PC",
//        Price = 65000,
//        ActionPrice = 55000,
//        Description = "Perfect PC",
//        DescriptionField1 = "Super PC",
//        DescriptionField2 = "Top PC",
//        ImageUrl = "httpPCImageUrl",
//        Category = new Category()
//        {
//            Name = "PC",
//            Icon = "PC"
//        },
//        Cart = new List<Cart>(new Cart[]
//        {
//            new Cart()
//            {
//                UsersUser = new User()
//                {
//                    Name = "Viktor",
//                    Login = "viktor",
//                    Password = "112233",
//                    Email = "viktor@gmail.com"
//                }
//            }
//        }),
//        KeyWords = new List<KeyParams>(new KeyParams[]
//        {
//            new KeyParams()
//            {
//                KeyWords = new Word()
//                {
//                    Header = "PC",
//                    KeyWord = "PC, Computer"
//                }
//            }
//        })
//    });
//    database.Products.AddAsync(new Product()
//    {
//        Name = "Vacuum cleaner",
//        Price = 15000,
//        ActionPrice = 12000,
//        Description = "Perfect Vacuum cleaner",
//        DescriptionField1 = "Super Vacuum cleaner",
//        DescriptionField2 = "Top Vacuum cleaner",
//        ImageUrl = "httpVacuumcleanerImageUrl",
//        Category = new Category()
//        {
//            Name = "Technick",
//            Icon = "Technick"
//        },
//        Cart = new List<Cart>(new Cart[]
//        {
//            new Cart()
//            {
//                UsersUser = new User()
//                {
//                    Name = "Viktor",
//                    Login = "viktor",
//                    Password = "112233",
//                    Email = "viktor@gmail.com"
//                }
//            }
//        }),
//        KeyWords = new List<KeyParams>(new KeyParams[]
//        {
//            new KeyParams()
//            {
//                KeyWords = new Word()
//                {
//                    Header = "Vacuum cleaner",
//                    KeyWord = "Vacuum cleaner, Vacuum, cleaner"
//                }
//            }
//        })
//    });
//    database.Products.AddAsync(new Product()
//    {
//        Name = "Mouse",
//        Price = 100,
//        ActionPrice = 80,
//        Description = "Perfect Mouse",
//        DescriptionField1 = "Super Mouse",
//        DescriptionField2 = "Top Mouse",
//        ImageUrl = "httpMouseImageUrl",
//        Category = new Category()
//        {
//            Name = "Electronic",
//            Icon = "Electronic"
//        },
//        Cart = new List<Cart>(new Cart[]
//        {
//            new Cart()
//            {
//                UsersUser = new User()
//                {
//                    Name = "Dina",
//                    Login = "dina",
//                    Password = "123",
//                    Email = "dina@gmail.com"
//                }
//            }
//        }),
//        KeyWords = new List<KeyParams>(new KeyParams[]
//        {
//            new KeyParams()
//            {
//                KeyWords = new Word()
//                {
//                    Header = "Mouse",
//                    KeyWord = "Mouse"
//                }
//            }
//        })
//    });
//    database.Products.AddAsync(new Product()
//    {
//        Name = "Washing machine",
//        Price = 1000,
//        ActionPrice = 800,
//        Description = "Perfect Washing machine",
//        DescriptionField1 = "Super Washing machine",
//        DescriptionField2 = "Top Washing machine",
//        ImageUrl = "httpWashingmachineImageUrl",
//        Category = new Category()
//        {
//            Name = "Technick",
//            Icon = "Technick"
//        },
//        Cart = new List<Cart>(new Cart[]
//        {
//            new Cart()
//            {
//                UsersUser = new User()
//                {
//                    Name = "Dina",
//                    Login = "dina",
//                    Password = "123",
//                    Email = "dina@gmail.com"
//                }
//            }
//        }),
//        KeyWords = new List<KeyParams>(new KeyParams[]
//        {
//            new KeyParams()
//            {
//                KeyWords = new Word()
//                {
//                    Header = "Washing machine",
//                    KeyWord = "Washing machine, Washing, machine"
//                }
//            }
//        })
//    });

//        database.SaveChanges();
//}

using (MyDatabaseContext database = new MyDatabaseContext())
{
    var products = database.Products.Include(c => c.Category)
        .Include(c => c.Cart).Include(k => k.KeyWords).ToList();

    var user = database.Users
        .Include(c => c.Cart)
            .ThenInclude(p => p.Product)
            .ThenInclude(k => k.KeyWords)
            .ThenInclude(w => w.KeyWords)
        .Include(p => p.Cart)
            .ThenInclude(p => p.Product)
            .ThenInclude(c => c.Category).FirstOrDefault();

    Console.WriteLine($"User: {user.Name}\n" +
                      $"Category: {user.Cart.FirstOrDefault().Product.Category.Name}\n" +
                      $"Product: {user.Cart.FirstOrDefault().Product.Name}\n" +
                      $"Key words: {user.Cart.FirstOrDefault().Product.KeyWords.FirstOrDefault().KeyWords.KeyWord}");

}

//using (MyDatabaseContext database = new MyDatabaseContext())
//{
//    database.Categories.AddAsync(new Category()
//    {
//        Name = "Electronic",
//        Icon = "Electronic"
//    });
//    database.Categories.AddAsync(new Category()
//    {
//        Name = "Technick",
//        Icon = "Technick"
//    });
//    database.Categories.AddAsync(new Category()
//    {
//        Name = "PC",
//        Icon = "PC",
//    });

//    database.SaveChanges();
//}

//using (MyDatabaseContext database = new MyDatabaseContext())
//{
//    database.Words.AddAsync(new Word()
//    {
//        Header = "MyElectronicKeys",
//        KeyWord = "Electronic, Phone"
//    });
//    database.Words.AddAsync(new Word()
//    {
//        Header = "MyTechnickKeys",
//        KeyWord = "Technick"
//    });
//    database.Words.AddAsync(new Word()
//    {
//        Header = "MyKeys",
//        KeyWord = "PC"
//    });

//    database.SaveChanges();
//}

//using (MyDatabaseContext database = new MyDatabaseContext())
//{
//    try
//    {
//        var products = database.Products.ToList();
//        for (int i = 0; i < products.Count; i++)
//        {

//            if (i == 1 || i == 0 || i == 5 || i == 7)
//            {
//                Console.WriteLine($"Name: {products[i].Name}\n" +
//                                  $"Cost: {products[i].Price}\n" +
//                                  $"Description: {products[i].Description}\n" +
//                                  $"Quantity: {products[i].Description}\n");
//            }
//        }
//    }
//    catch (Exception ex)
//    {
//        using (MyDatabaseContext db = new MyDatabaseContext())
//        {
//            database.Errors.Add(new Error()
//            {
//                Message = ex.Message,
//                Time = DateTime.Now,
//                Status = StatusCode.NotFound
//            });
//        }
//    }

//}
