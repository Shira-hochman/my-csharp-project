using Dal_Repository;
namespace Bll_Services
{
    public class ProducrBll: IProductBll
    {
        Dal_Repository.IDalRepository IDal;
       
        public ProducrBll(IDalRepository dal)
        {
            IDal = dal;
        }
        public async Task<List<Dto_Common_Enteties.ProductDto>> SelectAllAsync()
        {

            return await IDal.SelectAllAsync();
        }
        public async Task<List<Dto_Common_Enteties.ProductDto>> GetByIdAsync(string n)
        {
            return await IDal.GetByIdAsync(n);
        }
        public async Task<List<Dto_Common_Enteties.ProductDto>> GetProductsByCategoriesAsync(List<int> categoryIds)
        {
            return await IDal.GetProductsByCategoriesAsync(categoryIds);
        }

        public async Task<List<Dto_Common_Enteties.ProductDto>> GetPriceAsync(int minPrice, int maxPrice)
        {
            return await IDal.GetPriceAsync(minPrice, maxPrice);
        }
    }
}
