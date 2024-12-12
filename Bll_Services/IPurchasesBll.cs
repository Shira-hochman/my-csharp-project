using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public interface IPurchasesBll
    {
        Task<PurchasesDto> AddPayAsync(Dto_Common_Enteties.PurchasesDto purchases);
    }
}