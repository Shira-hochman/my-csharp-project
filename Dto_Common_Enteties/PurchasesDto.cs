using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto_Common_Enteties
{
    public class PurchasesDto
    {
        public int PurchaseId { get; set; }

        public int CustomerId { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public decimal? TotalAmount { get; set; }

        public string? Note { get; set; }

    }
}
