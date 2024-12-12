using Dal_Repository.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class PurchasesDal:IPurchases
    {
        public async Task Pay(Dto_Common_Enteties.PurchasesDto purchases)
        {
            using (ToyStoreContext db = new ToyStoreContext())
            {
                var purchaseEntity = modelsConverters.PurchasesConverter.ToPurchases(purchases);
                db.Purchases.Add(purchaseEntity); // מוסיף את הרכישה למסד הנתונים
                int changes = await db.SaveChangesAsync(); // מחזיר את מספר השורות שעודכנו

                if (changes > 0)
                {
                    purchases.PurchaseId = purchaseEntity.PurchaseId;  // מעדכן את ה-DTO עם ה-ID החדש
                }
                else
                {
                    throw new Exception("לא התבצעו שינויים במסד הנתונים");
                }
            }
        }


    }
}
