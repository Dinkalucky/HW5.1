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
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Create(User entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                try
                {
                    await database.Users.AddAsync(new User()
                    {
                        Id = entity.Id,
                        Name = entity.Name,
                        Login = entity.Login,
                        Password = entity.Password,
                        Email = entity.Email,
                        Cart = entity.Cart
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

        public async Task<bool> Delete(User entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                User user = database.Users.FirstOrDefault(c => c.Name == entity.Name);
                if (user != null)
                {
                    database.Users.Remove(user);
                    database.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<User> GetById(Guid id)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                User user = database.Users.FirstOrDefault(c => c.Id == id);
                return user != null ? user : null;
            }
        }

        public async Task<IEnumerable<User>> Select()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var user = database.Users.Select(c => new User()).ToList();
                return user;
            }
        }

        public async Task<User> Update(User entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var user = database.Users.Update(entity).Entity;
                return user;
            }
        }
    }
}
