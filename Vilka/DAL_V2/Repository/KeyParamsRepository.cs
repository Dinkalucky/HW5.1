using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class KeyParamsRepository : IKeyParamsRepository
    {
        public async Task<bool> Create(KeyParams entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                try
                {
                    await database.KeyParams.AddAsync(new KeyParams()
                    {
                        Id = entity.Id,
                        Product = entity.Product,
                        KeyWords = entity.KeyWords
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

        public async Task<bool> Delete(KeyParams entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                KeyParams keyParams = database.KeyParams.FirstOrDefault(c => c.Product == entity.Product);
                if (keyParams != null)
                {
                    database.KeyParams.Remove(keyParams);
                    database.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<KeyParams> GetById(Guid id)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                KeyParams keyParams = database.KeyParams.FirstOrDefault(c => c.Id == id);
                return keyParams != null ? keyParams : null;
            }
        }

        public async Task<IEnumerable<KeyParams>> Select()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var keyParams = database.KeyParams.Select(c => new KeyParams()).ToList();
                return keyParams;
            }
        }

        public async Task<IEnumerable<KeyParams>> SelectIncludeWords()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var keyParams = database.KeyParams.Include(p => p.KeyWords).Select(c => new KeyParams()).ToList();
                return keyParams;
            }
        }

        public async Task<KeyParams> Update(KeyParams entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var keyParams = database.KeyParams.Update(entity).Entity;
                return keyParams;
            }
        }
    }
}
