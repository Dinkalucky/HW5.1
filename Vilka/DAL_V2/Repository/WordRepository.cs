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
    public class WordRepository : IWordRepository
    {
        public async Task<bool> Create(Word entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                try
                {
                    await database.Words.AddAsync(new Word()
                    {
                        Id = entity.Id,
                        Header = entity.Header,
                        KeyWord = entity.KeyWord,
                        ProductLink = entity.ProductLink

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

        public async Task<bool> Delete(Word entity)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Word word = database.Words.FirstOrDefault(c => c.Header == entity.Header);
                if (word != null)
                {
                    database.Words.Remove(word);
                    database.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<Word> GetById(Guid id)
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                Word word = database.Words.FirstOrDefault(c => c.Id == id);
                return word != null ? word : null;
            }
        }


        public async Task<IEnumerable<Word>> Select()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var word = database.Words.Select(c => new Word()).ToList();
                return word;
            }
        }

        public async Task<IEnumerable<Word>> SelectIncludeKeyParamsProducts()
        {
            using (EntityDatabase database = new EntityDatabase())
            {
                var word = database.Words.Include(k=>k.KeyWord).Select(c => new Word()).ToList();
                return word;
            }
        }

            public async Task<Word> Update(Word entity)
            {
                using (EntityDatabase database = new EntityDatabase())
                {
                    var word = database.Words.Update(entity).Entity;
                    return word;
                }
            }
        
    }
}
