using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public interface ICustomerBll
    {
        Task<List<Dto_Common_Enteties.CustomerDto>> SelectAllAsync();
         Task AddAsync(Dto_Common_Enteties.CustomerDto customer);
    }
}
