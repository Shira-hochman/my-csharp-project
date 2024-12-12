using Dal_Repository.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.modelsConverters
{
    internal class PurchaseDetailsConverter
    {
        public PurchaseDetailsConverter()
        {
        }

        public static Dto_Common_Enteties.PurchaseDetailsDto ToPurchaseDetailsDto(models.PurchaseDetail pd)
        {
            Dto_Common_Enteties.PurchaseDetailsDto p = new Dto_Common_Enteties.PurchaseDetailsDto();
            p.Quantity = pd.Quantity;
            p.PurchaseId = pd.PurchaseId;
            p.ProductId = pd.ProductId;
            p.PurchaseDetailId = pd.PurchaseDetailId;
            return p;
        }

        public static List<Dto_Common_Enteties.PurchaseDetailsDto> ToPurchaseDetailsDtoList(List<models.PurchaseDetail> lpr)
        {
            List<Dto_Common_Enteties.PurchaseDetailsDto> l = new List<Dto_Common_Enteties.PurchaseDetailsDto>();
            foreach (var product in lpr)
            {
                l.Add(ToPurchaseDetailsDto(product));
            }
            return l;
        }

        // כאן הוספנו את הפונקציה הממירה
        public static List<models.PurchaseDetail> ToPurchaseDetails(List<Dto_Common_Enteties.PurchaseDetailsDto> purchaseDetailsDto)
        {
            List<models.PurchaseDetail> purchaseDetails = new List<models.PurchaseDetail>();

            foreach (var dto in purchaseDetailsDto)
            {
                models.PurchaseDetail detail = new models.PurchaseDetail();
                detail.PurchaseId = dto.PurchaseId;
                detail.ProductId = dto.ProductId;
                detail.Quantity = dto.Quantity;
                detail.PurchaseDetailId = dto.PurchaseDetailId;

                purchaseDetails.Add(detail);
            }

            return purchaseDetails;
        }

    }
}
