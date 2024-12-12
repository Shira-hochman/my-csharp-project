using Dal_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class CategoryBll:ICategoryBll
    {
        Dal_Repository.ICategory IDal;

        public CategoryBll(ICategory dal)
        {
            IDal = dal;
        }
        public async Task<List<Dto_Common_Enteties.CategoryDto>> SelectAllAsync()
        {

            return await IDal.SelectAllAsync();
        }
    }
}
