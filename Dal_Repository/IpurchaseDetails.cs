using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public interface IpurchaseDetails
    {
        Task postDetails(List<Dto_Common_Enteties.PurchaseDetailsDto> purchaseDetails);
    }
}
