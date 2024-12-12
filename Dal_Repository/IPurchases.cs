using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public interface IPurchases
    {
        Task Pay(Dto_Common_Enteties.PurchasesDto purchases);
    }
}
