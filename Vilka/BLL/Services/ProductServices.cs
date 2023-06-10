using BLL.Entity;
using BLL.Interfaces.Repository;
using BLL.Interfaces.Services;
using DAL_V2.Entity;
using System.Xml.Linq;
using KeyParams = BLL.Entity.KeyParams;
using Product = BLL.Entity.Product;

namespace BLL.Services
{
    public class ProductServices : IProductServices
    {
        IProductRepository _productRepository;
        IKeyParamsRepository _keyParams;
        private IWordRepository _wordRepository;
        public ProductServices(IProductRepository userRepository, IKeyParamsRepository keyParams, IWordRepository wordRepository)
        {
            _productRepository = userRepository;
            _keyParams = keyParams;
            _wordRepository = wordRepository;
        }
        public async Task<bool> CreateProduct(Product entity)
        {
            return await _productRepository.Create(entity);
        }

        public async Task<bool> DeleteProduct(Product entity)
        {
            return await _productRepository.Delete(entity);
        }

        public async Task<Product> GetProductById(Guid id)
        {
            return await _productRepository.GetById(id);
        }

        public async Task<IEnumerable<Product>> AllProducts()
        {
            return await _productRepository.Select();
        }

        public async Task<Product> UpdateProduct(Product entity)
        {
            return await _productRepository.Update(entity);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAndPrice(string category, int max, int min)
        {
            var products = await _productRepository.Select();
            return products.Where(p => p.Category.Name == category &&
                                       p.Price >= min &&
                                       p.Price <= max);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAndKeyWordsWithPrice(string category, string[] keywords, int max, int min)
        {
            var products = await _productRepository.Select();
            var keyParams = await _keyParams.SelectIncludeWords();

            return products.Where(p => p.Category.Name == category &&
                                                        p.Price >= min &&
                                                        p.Price <= max &&
                                                        keywords.All(kw => keyParams.Any(kp => kp.Product == p && kp.KeyWords.KeyWord == kw)));
        }

        public async Task<Product> GetProductByName(string name)
        {
            var products = await _productRepository.Select();
            return products.First(x => x.Name == name);
        }

        public async Task<IEnumerable<Product>> ProductsByWord(string word)
        {
            var allProducts = await _productRepository.Select();

            return allProducts.Where(p => p.Name.Contains(word));
        }
    }

}
