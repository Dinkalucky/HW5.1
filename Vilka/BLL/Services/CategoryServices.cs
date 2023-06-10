using BLL.Entity;
using BLL.Interfaces.Repository;
using BLL.Interfaces.Services;
using System.Xml.Linq;
using KeyParams = BLL.Entity.KeyParams;
using Product = BLL.Entity.Product;

namespace BLL.Services
{
    public class CategoryServices : ICategoryServices
    {
        ICategoryRepository _categoryRepository;
        IKeyParamsRepository _keyParamsRepository;
        IProductServices _productServices;
        public CategoryServices(ICategoryRepository userRepository, IKeyParamsRepository keyproductRepository, IProductServices productServices)
        {
            _categoryRepository = userRepository;
            _keyParamsRepository = keyproductRepository;
            _productServices = productServices;
        }
        public async Task<bool> CreateCategory(Category entity)
        {
            return await _categoryRepository.Create(entity);
        }

        public async Task<bool> DeleteCategory(Category entity)
        {
            return await _categoryRepository.Delete(entity);
        }

        public async Task<Category> GetCategoryById(Guid id)
        {
            return await _categoryRepository.GetById(id);
        }
        public async Task<Category> GetCategoryByName(string category)
        {
            var categories = await _categoryRepository.Select();
            return categories.First(x => x.Name == category);
        }

        public async Task<IEnumerable<Category>> AllCategories()
        {
            return await _categoryRepository.Select();
        }

        public async Task<Category> UpdateCategory(Category entity)
        {
            return await _categoryRepository.Update(entity);
        }


        public async Task<CategoryInfo> GetCategoryInfoByName(string category)
        {
            var categoryEntity = await GetCategoryByName(category);

            var products = await _productServices.GetProductsByCategoryAndPrice(category, Int32.MaxValue, 0);
            var keyParams = await _keyParamsRepository.SelectIncludeWords();

            var selections = new Dictionary<string, string[]>();

            foreach (var keyParam in keyParams)
            {
                var key = keyParam.KeyWords.Header;
                var values = keyParams.Where(kp => kp.KeyWords.Header == key).Select(kp => kp.KeyWords.KeyWord).ToArray();

                selections[key] = values;
            }

            var maxPrice = products.Max(p => p.Price);
            var minPrice = products.Min(p => p.Price);

            var categoryInfo = new CategoryInfo
            {
                Selections = selections,
                MaxPrice = maxPrice,
                MinPrice = minPrice,
                CategoryName = categoryEntity.Name
            };

            return categoryInfo;
        }
    }
}