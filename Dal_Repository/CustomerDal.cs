using Dal_Repository.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class CustomerDal:ICustomer
    {
       public async Task<List<Dto_Common_Enteties.CustomerDto>> SelectAllAsync()
        {
            using (ToyStoreContext db = new ToyStoreContext())
            {
                var l = await db.Customers.ToListAsync();
                return modelsConverters.CustomerConvert.TocustomertDtoList(l);
            }
        }
        public async Task InsertAsync(Dto_Common_Enteties.CustomerDto customer)
        {
       
            using (ToyStoreContext db = new ToyStoreContext())
            {
                var ac = db.Customers
                    .Add(modelsConverters.CustomerConvert.ToCustomer(customer));
                await db.SaveChangesAsync();
            }
         
    }
        
            
    }
}
