using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public interface ICategoryBll
    {
        public Task<List<Dto_Common_Enteties.CategoryDto>> SelectAllAsync();
    }
}
