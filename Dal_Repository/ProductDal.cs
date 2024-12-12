using Dal_Repository.models;
using Dto_Common_Enteties;
using Microsoft.EntityFrameworkCore;
namespace Dal_Repository
{
    public class ProductDal: IDalRepository
    {
        public async Task<List<Dto_Common_Enteties.ProductDto>> SelectAllAsync()
        {
            using (ToyStoreContext db = new ToyStoreContext())
            {
                var l = await db.Products.Include(p=>p.Category).ToListAsync();
                return modelsConverters.ProductConverter.ToProductDtoList(l);
            }

        }
        public async Task<List<Dto_Common_Enteties.ProductDto>> GetByIdAsync(string n)
        {
            using (ToyStoreContext db = new ToyStoreContext())
            {
                var  l = await db.Products.Include(p => p.Category)
                         .Where(p => p.Category.CategoryName == n)
                         .ToListAsync();



                return modelsConverters.ProductConverter.ToproductDto(l);

            }
        
        }
        public async Task<List<Dto_Common_Enteties.ProductDto>> GetProductsByCategoriesAsync(List<int> categoryIds)
        {
            using (ToyStoreContext db = new ToyStoreContext())
            {
                var products = await db.Products
                    .Include(p => p.Category)
                    .Where(p => categoryIds.Contains(p.CategoryId))
                    .ToListAsync();

                return modelsConverters.ProductConverter.ToProductDtoList(products);
            }
        }
        public async Task<List<Dto_Common_Enteties.ProductDto>> GetPriceAsync(int minPrice,int maxPrice)
        {
            using (ToyStoreContext db = new ToyStoreContext())
            {
                var products = await db.Products
                 .Where(p => p.Price >= minPrice && p.Price <= maxPrice)
                     .ToListAsync();


                return modelsConverters.ProductConverter.ToProductDtoList(products);
            }
        }

    }
}
