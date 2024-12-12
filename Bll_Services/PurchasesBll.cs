using Dal_Repository;
using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class PurchasesBll :IPurchasesBll
    {
        Dal_Repository.IPurchases IDal;

        public PurchasesBll(IPurchases dal)
        {
            IDal = dal;
        }
        public async Task<PurchasesDto> AddPayAsync(Dto_Common_Enteties.PurchasesDto purchases)
        {
            await IDal.Pay(purchases);  // שומר את הרכישה במסד הנתונים
            return purchases;  // מחזיר את ה-DTO עם ה-ID המעודכן
        }


    }
}
