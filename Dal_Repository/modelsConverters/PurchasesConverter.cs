using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.modelsConverters
{
    internal class PurchasesConverter
    {
        public PurchasesConverter()
        {

        }
        public static Dto_Common_Enteties.PurchasesDto ToPurchasesDto(models.Purchase pu)
        {
            Dto_Common_Enteties.PurchasesDto p = new Dto_Common_Enteties.PurchasesDto();
            p.CustomerId = pu.CustomerId;
            p.PurchaseId = pu.PurchaseId;
            p.PurchaseDate = pu.PurchaseDate;
            p.Note = pu.Note;
            p.TotalAmount = pu.TotalAmount;
            return p;
        }
        public static models.Purchase ToPurchases(Dto_Common_Enteties.PurchasesDto pu)
        {
            models.Purchase p = new models.Purchase();
            p.CustomerId = pu.CustomerId;
            p.PurchaseId = pu.PurchaseId;
            p.PurchaseDate = pu.PurchaseDate;
            p.Note = pu.Note;
            p.TotalAmount = pu.TotalAmount;
            return p;
        }
    }
}