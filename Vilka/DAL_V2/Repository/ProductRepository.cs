using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_V2.Repository
{
    public class ProductRepository : IProductRepository
    {
        public async Task<bool> Create(Product entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                try
                {
                    await database.Products.AddAsync(new Product()
                    {
                        Id = entity.Id,
                        Name = entity.Name,
                        Price = entity.Price,
                        ActionPrice = entity.ActionPrice,
                        Description = entity.Description,
                        DescriptionField1 = entity.DescriptionField1,
                        DescriptionField2 = entity.DescriptionField2,
                        ImageUrl = entity.ImageUrl,
                        Category = entity.Category,
                        Cart = entity.Cart,
                        KeyWords = entity.KeyWords,
                    });
                    await database.SaveChangesAsync();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

            }
        }

        public async Task<bool> Delete(Product entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Product product = database.Products.FirstOrDefault(c => c.Name == entity.Name);
                if (product != null)
                {
                    database.Products.Remove(product);
                    database.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<Product> GetById(Guid id)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Product product = database.Products.FirstOrDefault(c => c.Id == id);
                return product != null ? product : null;
            }
        }

        public async Task<Product> GetByIdIncludWord(string name)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Product product = database.Products.Include(w=>w.KeyWords).FirstOrDefault(c => c.Name == name);
                return product != null ? product : null;
            }
        }

        public async Task<IEnumerable<Product>> Select()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var product = database.Products.Select(c => new Product()).ToList();
                return product;
            }
        }
        public async Task<IEnumerable<Product>> SelectIncludeCategory()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var product = database.Products.Include(c=>c.Category).Select(c => new Product()).ToList();
                return product;
            }
        }

        public async Task<Product> Update(Product entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var product = database.Products.Update(entity).Entity;
                return product;
            }
        }
    }
}
