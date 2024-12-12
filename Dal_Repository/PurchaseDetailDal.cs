using Dal_Repository.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class PurchaseDetailDal : IpurchaseDetails
    {

        public async Task postDetails(List<Dto_Common_Enteties.PurchaseDetailsDto> purchaseDetails)
        {
            using (ToyStoreContext db = new ToyStoreContext())
            {
                // המרה של רשימת PurchaseDetailsDto לרשימת PurchaseDetail
                var purchaseDetailsList = modelsConverters.PurchaseDetailsConverter.ToPurchaseDetails(purchaseDetails);  // עכשיו המרנו ל-PurchaseDetail

                // הוספת כל הרשימה לבסיס הנתונים
                db.PurchaseDetails.AddRange(purchaseDetailsList);  // הוספת הרשימה המומרת
                await db.SaveChangesAsync();
            }
        }


    }
}




