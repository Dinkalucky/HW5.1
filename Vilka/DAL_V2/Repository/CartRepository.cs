using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace DAL_V2.Repository
{
    public class CartRepository : ICartRepository
    {
        public async Task<bool> Create(Cart entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                try
                {
                   await database.Carts.AddAsync(new Cart()
                    {
                        Id = entity.Id,
                        UsersUser = entity.UsersUser,
                        Product = entity.Product
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

        public async Task<bool> Delete(Cart entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Cart cart = database.Carts.FirstOrDefault(c => c.UsersUser == entity.UsersUser);
                if (cart != null)
                {
                    database.Carts.Remove(cart);
                    database.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public async Task<Cart?> GetById(Guid id)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Cart cart = database.Carts.FirstOrDefault(c => c.Id == id);
                return cart != null ? cart : null;
            }
        }

        public async Task<IEnumerable<Cart>> Select()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var cart = database.Carts.Select(c => new Cart()).ToList();
                return cart;
            }
        }

        public async Task<Cart> Update(Cart entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var cart = database.Carts.Update(entity).Entity;
                return cart;
            }
        }
    }
}
