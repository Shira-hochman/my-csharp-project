using Dal_Repository.models;
using Dto_Common_Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class CategoryDal : ICategory
    {
        public async Task<List<Dto_Common_Enteties.CategoryDto>> SelectAllAsync()
        {
            using (ToyStoreContext db = new ToyStoreContext())
            {
                var l=await db.Categories.ToListAsync();
                return modelsConverters.CategoryConverter.ToCategorytDtoList(l);
            }
        }
    }
}