﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public interface IProductBll
    {
         Task<List<Dto_Common_Enteties.ProductDto>> SelectAllAsync();

         Task<List<Dto_Common_Enteties.ProductDto>> GetByIdAsync(string n);
       
        Task<List<Dto_Common_Enteties.ProductDto>> GetProductsByCategoriesAsync(List<int> categoryIds);
        Task<List<Dto_Common_Enteties.ProductDto>> GetPriceAsync(int minPrice, int maxPrice);
    }
}
