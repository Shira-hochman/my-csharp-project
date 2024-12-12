using Dal_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class CustomerBll : ICustomerBll
    {
        Dal_Repository.ICustomer IDal;

        public CustomerBll(ICustomer dal)
        {
            IDal = dal;
        }
        public async  Task<List<Dto_Common_Enteties.CustomerDto>> SelectAllAsync()
        {
            return await IDal.SelectAllAsync(); 
        }
      public  async Task AddAsync(Dto_Common_Enteties.CustomerDto customer)
        {
            await IDal.InsertAsync(customer);
        }
    }
}
