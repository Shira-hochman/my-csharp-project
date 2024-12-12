using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto_Common_Enteties
{
    public class PurchaseDetailsDto
    {
        public int PurchaseDetailId { get; set; }

        public int PurchaseId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
