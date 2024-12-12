using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public interface IPurchaseDetailsBll
    {
        Task AddDetailsAsync(List<Dto_Common_Enteties.PurchaseDetailsDto> purchaseDetails);
    }
}
