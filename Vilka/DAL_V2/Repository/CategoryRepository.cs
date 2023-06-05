using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public async Task<bool> Create(Category entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                try
                {
                    await database.Categories.AddAsync(new Category()
                    {
                        Id = entity.Id,
                        Name = entity.Name,
                        Icon = entity.Icon,
                        Products = entity.Products
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

        public async Task<bool> Delete(Category entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Category category = database.Categories.FirstOrDefault(c => c.Name == entity.Name);
                if (category != null)
                {
                    database.Categories.Remove(category);
                    database.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<Category> GetById(Guid id)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Category category = database.Categories.FirstOrDefault(c => c.Id == id);
                return category != null ? category : null;
            }
        }

        public async Task<IEnumerable<Category>> Select()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var category = database.Categories.Select(c => new Category()).ToList();
                return category;
            }
        }

        public async Task<IEnumerable<Category>> SelectIncludeProducts()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var category = database.Categories.Include(p=>p.Products).Select(c => new Category()).ToList();
                return category;
            }
        }

        public async Task<Category> Update(Category entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var category = database.Categories.Update(entity).Entity;
                return category;
            }
        }
    }
}
