using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public interface ICustomer
    {
        Task<List<Dto_Common_Enteties.CustomerDto>> SelectAllAsync();
        Task InsertAsync(Dto_Common_Enteties.CustomerDto customer);
    }
}
