using Dal_Repository;
using Dal_Repository.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class PurchaseDetailsBll : IPurchaseDetailsBll
    {
        private readonly IpurchaseDetails IDal;

        public PurchaseDetailsBll(IpurchaseDetails dal)
        {
            IDal = dal;
        }

        public async Task AddDetailsAsync(List<Dto_Common_Enteties.PurchaseDetailsDto> purchaseDetails)
        {
            await IDal.postDetails(purchaseDetails); // שולח את הרשימה כולה
        }
    
}
}
