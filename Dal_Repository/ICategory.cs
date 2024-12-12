using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public interface ICategory
    {
        Task<List<Dto_Common_Enteties.CategoryDto>> SelectAllAsync();
    }
}
